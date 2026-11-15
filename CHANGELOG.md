# Changelog

## [0.24.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.23.0...v0.24.0) (2026-11-15)


### Features

* Load a mod from a prebuilt DLL named in mod.toml ([84e497a](https://github.com/XeTrinityz/BmSDK-AK/commit/84e497a40c0d36468a9cc217a116c9fc3cb42040))

## [0.23.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.22.0...v0.23.0) (2026-11-15)


### Features

* Build the bindings from the dumps without the game ([51c9c93](https://github.com/XeTrinityz/BmSDK-AK/commit/51c9c93f04cbd41b46b28c4dee8ec2b530844be3))
* Classes implement their script interfaces ([b947a9b](https://github.com/XeTrinityz/BmSDK-AK/commit/b947a9bae44926918875cd2c7dbb8cd66c7a4858))
* Delegates are FScriptDelegate instead of IntPtr ([9d00802](https://github.com/XeTrinityz/BmSDK-AK/commit/9d008024cb2882d18e05b6a3f60b3c67ba9d9e7d))
* **generator:** Dump the engine's reflection data while the game runs ([1c47b8e](https://github.com/XeTrinityz/BmSDK-AK/commit/1c47b8e87726c42578f155bdca963af258e5fee6))
* **generator:** Load the Season of Infamy maps, and make the output folder if it's missing ([204334d](https://github.com/XeTrinityz/BmSDK-AK/commit/204334d733f250ce7cc4e66292984e30f77a4bcb))
* Regenerate the bindings from a sweep of every package ([477b1b5](https://github.com/XeTrinityz/BmSDK-AK/commit/477b1b51017b9001e9990e17468d0b476d7ef251))
* Script consts as C# consts ([3a04cb2](https://github.com/XeTrinityz/BmSDK-AK/commit/3a04cb2ab9fac56b27652141a719dd399371d084))
* Show each property's default value in its summary ([dbac26e](https://github.com/XeTrinityz/BmSDK-AK/commit/dbac26e1af9683fc2ac7c508e988ebf7e3db28cb))
* Show where each native function's code is ([8bf2c79](https://github.com/XeTrinityz/BmSDK-AK/commit/8bf2c7915001ed329b29a3cb63e76099b7c716e6))


### Bug Fixes

* Log a class that falls back to its parent type as info, not a warning ([c275e97](https://github.com/XeTrinityz/BmSDK-AK/commit/c275e970f7eb0a75bd2b087d40a50856f65d2573))
* Read Class.ClassFlags from where the engine keeps it ([e707754](https://github.com/XeTrinityz/BmSDK-AK/commit/e70775494f5c6afc8d384b059a39a1df962ce995))

## [0.22.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.21.0...v0.22.0) (2026-11-15)


### Features

* Add Game.TryGet*, TArray.AddRange and Mod.State ([ce40acb](https://github.com/XeTrinityz/BmSDK-AK/commit/ce40acb3c3ae3221f4521202449aaa7879b78c34))
* Give scripts an OnDraw(Canvas) callback ([d1f73af](https://github.com/XeTrinityz/BmSDK-AK/commit/d1f73af5e9a18fb380e7281033f260bec260149b))
* Key presses while paused, swallow input by engine name, drop a swallowed key's character ([e2614b4](https://github.com/XeTrinityz/BmSDK-AK/commit/e2614b4063e35abb4e522e7decb019c530e0f360))
* Let a mod swallow keys so the game never sees them ([40c46b2](https://github.com/XeTrinityz/BmSDK-AK/commit/40c46b26e79c2fe00da6d73a819b6d0640dfbaed))
* Log slow frames with the time each mod callback and redirect took ([c7a3cc0](https://github.com/XeTrinityz/BmSDK-AK/commit/c7a3cc05a668a604238c3a5e4eedc934d92eafbf))
* Name the game function a native fault happened in before aborting ([97813d0](https://github.com/XeTrinityz/BmSDK-AK/commit/97813d010e605db562766807b8955bab10ed80a0))
* Pass strings by value without leaking, dispatch calls on the real class ([fec6e29](https://github.com/XeTrinityz/BmSDK-AK/commit/fec6e290d5b2c7f604ee317e5ca5381b30a36b93))
* Support Epic Games copies of Arkham Knight ([74713ab](https://github.com/XeTrinityz/BmSDK-AK/commit/74713ab41993a3f54710a6b3958f5d82cc894761))
* World, camera and exit callbacks, camera view, gamepad, timers and object headroom ([a086f9d](https://github.com/XeTrinityz/BmSDK-AK/commit/a086f9d737530b66c2bbd147da5c9b60992d0da2))


### Bug Fixes

* 16-align the parameter buffer of every generated call ([26b20df](https://github.com/XeTrinityz/BmSDK-AK/commit/26b20df5d5f5b9fc53ce0232d04c1aab538a939a))
* Carry out parameters through redirects in both directions ([d3dc5ba](https://github.com/XeTrinityz/BmSDK-AK/commit/d3dc5ba19216df61dfd95e11d2e48807adc19b8c))
* Don't cache a wrongly typed wrapper for objects created before their class is registered ([e192625](https://github.com/XeTrinityz/BmSDK-AK/commit/e192625d42e877b7ce9969d80b24876ecff0276b))
* Keep out and return TArrays valid after the call ([948ebbf](https://github.com/XeTrinityz/BmSDK-AK/commit/948ebbfecc02309c17623afbf08f3ff8823dd9d9))
* Keep the exact function when a redirect calls itself ([3af9b0c](https://github.com/XeTrinityz/BmSDK-AK/commit/3af9b0c93e8618537df77ebc9ce8d7f9efa9dd3e))
* Keep the game running when a mod throws ([f14addd](https://github.com/XeTrinityz/BmSDK-AK/commit/f14addd361682efe6885d4d501e26b2bc30d1d39))
* Keep the game running when work posted to the engine thread throws ([42899d6](https://github.com/XeTrinityz/BmSDK-AK/commit/42899d60e5b134f9dd0fef759a86e92e1919bf24))
* Let static natives run on an instance, and fail cleanly on a destroyed wrapper ([c68fe90](https://github.com/XeTrinityz/BmSDK-AK/commit/c68fe9089b37a794715d6a32d05c41801aeab0d6))
* Lock the wrapper tables, the game creates and destroys objects off the main thread ([c5d1d84](https://github.com/XeTrinityz/BmSDK-AK/commit/c5d1d842830ba93e254ecfdbce6236656b544684))
* Log an unknown class once, not once per object ([3e06184](https://github.com/XeTrinityz/BmSDK-AK/commit/3e06184a8a4342d11bc719033fc67e2672174448))
* Mark a wrapper made with new as invalid when its object is destroyed ([109c930](https://github.com/XeTrinityz/BmSDK-AK/commit/109c9302b606968f164f6d4eaf425fafbd827f4f))
* Pass UnrealScript out params in, not just out ([6ce0866](https://github.com/XeTrinityz/BmSDK-AK/commit/6ce0866b0e0d8fb0aeaad748a7d9945dd74d8773))
* Resolve overrides by walking the class chain, not the game's FindFunction ([bd1ff9f](https://github.com/XeTrinityz/BmSDK-AK/commit/bd1ff9fe3da645d87f3d40b33037fd4a32680a5d))
* Size structs by their array stride and print inherited members ([b471c68](https://github.com/XeTrinityz/BmSDK-AK/commit/b471c688e4408495ce91c2ce2a0416211c7ccf0f))
* Stop optional string/array arguments being freed before a script call runs ([33ae040](https://github.com/XeTrinityz/BmSDK-AK/commit/33ae040970eb52c5a20a2bfa20c55012994de588))
* Treat every key as released when the window loses focus ([43558a2](https://github.com/XeTrinityz/BmSDK-AK/commit/43558a286521fe7c45575100c8e298dd12baea93))
* Wrap objects created before their class registered as soon as it has ([d5fa63c](https://github.com/XeTrinityz/BmSDK-AK/commit/d5fa63ce7ef0ecccd014e7487af704555a2450f8))


### Performance Improvements

* Build each class's function table once instead of walking its fields per call site ([0be8093](https://github.com/XeTrinityz/BmSDK-AK/commit/0be80936f23beff957f86b368ded9b7d1f79ff65))
* Cache each generated function's UFunction lookup ([b993c53](https://github.com/XeTrinityz/BmSDK-AK/commit/b993c5355990fdeb5bc20aa5642e25747e360efb))
* Cut the cost of script calls, redirects and startup ([d6492fd](https://github.com/XeTrinityz/BmSDK-AK/commit/d6492fd502133b68510c177dcd9528f923032f81))
* Stop allocating per object and per call, which caused the streaming stutter ([#13](https://github.com/XeTrinityz/BmSDK-AK/issues/13)) ([d619462](https://github.com/XeTrinityz/BmSDK-AK/commit/d6194620bf72db54fca81fcbce79cef631cf8592))
* Take string work out of the ProcessInternal detour and redirect calls ([a61d5a4](https://github.com/XeTrinityz/BmSDK-AK/commit/a61d5a405b45ccc2579ce7257fe7092496c48a4e))

## [0.21.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.19.0...v0.21.0) (2026-09-12)


### Features

* Add TArray.AsSpan() for ref access ([#138](https://github.com/Team-BmSDK/BmSDK-AK/issues/138)) ([cf2dd7c](https://github.com/Team-BmSDK/BmSDK-AK/commit/cf2dd7cc9252ab0b127913b1a323e2fb17485d62))
* Introduce and release an installer .exe for BmSDK ([#145](https://github.com/Team-BmSDK/BmSDK-AK/issues/145)) ([fa41f69](https://github.com/Team-BmSDK/BmSDK-AK/commit/fa41f69c0bbe6f3893e42f14f8749694af59b9df))

## [0.19.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.18.0...v0.19.0) (2026-09-09)


### Features

* Support Steam copies of Arkham City ([#133](https://github.com/Team-BmSDK/BmSDK-AK/issues/133)) ([74048ab](https://github.com/Team-BmSDK/BmSDK-AK/commit/74048ab8aa7d38340451c28ffb1ea3af00d5636a))

## [0.18.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.2...v0.18.0) (2026-08-23)


### Features

* Fall back to next known super in case of unknown class ([#131](https://github.com/Team-BmSDK/BmSDK-AK/issues/131)) ([acb7a26](https://github.com/Team-BmSDK/BmSDK-AK/commit/acb7a26e04ea5235c7f7adb3cc421ee21089a72b))
* Support DLC when launched from .exe ([#5](https://github.com/Team-BmSDK/BmSDK-AK/issues/5)) ([afbf42e](https://github.com/Team-BmSDK/BmSDK-AK/commit/afbf42e0df2b2e53d00c41cbf72378547bea9dca))


### Bug Fixes

* Fix scripts not being loaded since host update ([#127](https://github.com/Team-BmSDK/BmSDK-AK/issues/127)) ([5bb7ecb](https://github.com/Team-BmSDK/BmSDK-AK/commit/5bb7ecbe68400c715bb5da0bbf9da6287b7f67ed))

## [0.17.2](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.1...v0.17.2) (2026-07-10)


### Bug Fixes

* Fix scripts not being loaded since host update ([#3](https://github.com/Team-BmSDK/BmSDK-AK/issues/3)) ([ea9a098](https://github.com/Team-BmSDK/BmSDK-AK/commit/ea9a09845d40ca7ba2b603230d32ff9fe9d92de7))
* **input:** Fix OnKeyDown not firing when run through Steam ([#125](https://github.com/Team-BmSDK/BmSDK-AK/issues/125)) ([6f311a0](https://github.com/Team-BmSDK/BmSDK-AK/commit/6f311a02ebcc405e4255bbfef9e40a24698eaf67))

## [0.17.1](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.0...v0.17.1) (2026-07-10)


### Bug Fixes

* **host:** Use hostfxr_initialize_for_dotnet_command_line for self-contained support ([#122](https://github.com/Team-BmSDK/BmSDK-AK/issues/122)) ([8e9129b](https://github.com/Team-BmSDK/BmSDK-AK/commit/8e9129b6c4b55e128e1772449c7ae5d5cd9fef5d))

## [0.17.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.16.0...v0.17.0) (2026-07-09)


### Features

* Drop .NET Runtime dependency ([#120](https://github.com/Team-BmSDK/BmSDK/issues/120)) ([f8594c7](https://github.com/Team-BmSDK/BmSDK/commit/f8594c7d21b39929929213c5730d406d6b585900))
