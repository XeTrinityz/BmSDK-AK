#pragma once

#include <string>
#include <string_view>
#include <vector>
#include <cmath>
#include <format>

// Streams one JSON value into a string. Commas are placed automatically.
class JsonWriter
{
public:
    std::string Buf;

    void BeginObject() { Sep(); Buf += '{'; m_first.push_back(true); }
    void EndObject() { Buf += '}'; m_first.pop_back(); }
    void BeginArray() { Sep(); Buf += '['; m_first.push_back(true); }
    void EndArray() { Buf += ']'; m_first.pop_back(); }

    JsonWriter& Key(std::string_view key)
    {
        Sep();
        Quote(key);
        Buf += ':';
        m_afterKey = true;
        return *this;
    }

    void Str(std::string_view value) { Sep(); Quote(value); }
    void Int(int64_t value) { Sep(); Buf += std::to_string(value); }
    void UInt(uint64_t value) { Sep(); Buf += std::to_string(value); }
    void Bool(bool value) { Sep(); Buf += value ? "true" : "false"; }
    void Null() { Sep(); Buf += "null"; }
    void Hex(uint64_t value) { Str(std::format("0x{:X}", value)); }

    void Float(float value)
    {
        // JSON has no NaN or infinity, so those go out as strings.
        if (std::isfinite(value))
        {
            Sep();
            Buf += std::format("{}", value);
        }
        else
        {
            Str(std::format("{}", value));
        }
    }

    void Clear()
    {
        Buf.clear();
        m_first.clear();
        m_afterKey = false;
    }

private:
    std::vector<bool> m_first;
    bool m_afterKey = false;

    void Sep()
    {
        if (m_afterKey)
        {
            m_afterKey = false;
            return;
        }

        if (!m_first.empty())
        {
            if (!m_first.back())
            {
                Buf += ',';
            }
            m_first.back() = false;
        }
    }

    void Quote(std::string_view text)
    {
        Buf += '"';
        for (unsigned char c : text)
        {
            switch (c)
            {
                case '"': Buf += "\\\""; break;
                case '\\': Buf += "\\\\"; break;
                case '\n': Buf += "\\n"; break;
                case '\r': Buf += "\\r"; break;
                case '\t': Buf += "\\t"; break;
                default:
                    if (c < 0x20)
                    {
                        Buf += std::format("\\u{:04x}", c);
                    }
                    else
                    {
                        Buf += (char)c;
                    }
            }
        }
        Buf += '"';
    }
};
