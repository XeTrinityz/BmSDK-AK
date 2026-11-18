import type { Actions } from "./App";
import { api, errorText } from "./api";

/** Puts a summary of the setup and the latest logs on the clipboard, ready for a bug report. */
export async function copyDiagnostics(actions: Actions) {
  try {
    const text = await api.diagnostics();
    await navigator.clipboard.writeText(text);
    actions.toast("Diagnostics copied. Paste them into your bug report.", "success");
  } catch (e) {
    actions.toast(errorText(e), "error");
  }
}
