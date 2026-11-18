# Changelog

## [0.27.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.26.0...v0.27.0) (2026-11-18)


### Features

* Add Game.TryGetPlayerPawn ([175086c](https://github.com/XeTrinityz/BmSDK-AK/commit/175086ceb17fc216d0f969460d79268ce9aff3eb))
* Check for a newer BmSDK and say so for a few seconds in game ([3a52a63](https://github.com/XeTrinityz/BmSDK-AK/commit/3a52a63474852cf5f3245ba56d2e561eec2835aa))
* Keep the log of the session before and show it in the manager ([71d695e](https://github.com/XeTrinityz/BmSDK-AK/commit/71d695ee007685d0c3a500153b12da379f4875e1))
* Say in the manager that BmSDK doesn't work on a GOG copy ([3d87701](https://github.com/XeTrinityz/BmSDK-AK/commit/3d877016347cc336ff80e8fcf626f4b65d7abdc4))


### Bug Fixes

* A file deleted from a mod in the game no longer stops it turning back on ([342465d](https://github.com/XeTrinityz/BmSDK-AK/commit/342465decb62b39220c787c8e2f5faa51397a43c))
* AsyncTestScript no longer closes the game when there is no player controller ([c249604](https://github.com/XeTrinityz/BmSDK-AK/commit/c24960455ebee68b960445ae10a2273f5e2a6543))
* Check a redirect's parameters and result against the game function ([4e792a8](https://github.com/XeTrinityz/BmSDK-AK/commit/4e792a8798b4cbe0454e45e06aefb74809d3ce42))
* Check downloads against GitHub's hash instead of extra .sha256 files ([3a2915e](https://github.com/XeTrinityz/BmSDK-AK/commit/3a2915e88e498aa1f6564dc973a8cf99a83ee15e))
* Clear error lines from the screen after 20 seconds ([97f2fcf](https://github.com/XeTrinityz/BmSDK-AK/commit/97f2fcf3160ed4e5d644d67529c6cb1ac77ef5a0))
* Don't flag BmEngine.ini as changed because of the settings the game saves in it ([b72225a](https://github.com/XeTrinityz/BmSDK-AK/commit/b72225a1bc84f2a2596aef1e5c27a3e7ba89d217))
* Don't flag BmSDK.log as an added game file ([b8e4351](https://github.com/XeTrinityz/BmSDK-AK/commit/b8e43516cd08270ff8ec57dfd4cf0b619714cc32))
* Don't let a second copy of the manager run and overwrite the first one's list ([96d8e71](https://github.com/XeTrinityz/BmSDK-AK/commit/96d8e71d1c457ef3f2ce9cff5d9f49d13000bd23))
* Don't offer to recycle added files when the Steam build or language differs ([5d844a4](https://github.com/XeTrinityz/BmSDK-AK/commit/5d844a463275544066047d6e19b220ada93dddc4))
* Don't throw in the redirect and camera samples when there is no player ([9ad248c](https://github.com/XeTrinityz/BmSDK-AK/commit/9ad248c6224578bedf95c96c2396fb2cb12956f0))
* Don't use the author's source path as a prebuilt script's name ([f85d457](https://github.com/XeTrinityz/BmSDK-AK/commit/f85d457bf32e6c81da2cc1156a72c5ed85699008))
* Give up on a stalled update download instead of hanging ([28529e2](https://github.com/XeTrinityz/BmSDK-AK/commit/28529e2ea9ca0cd285eb5119f46a2d835ca5fc8f))
* Install every dropped mod after allowing access, not just the last ([fe78757](https://github.com/XeTrinityz/BmSDK-AK/commit/fe78757799d85b658073a06e239f9d4210ee1925))
* Keep a mod in its profiles when it's updated ([b488c43](https://github.com/XeTrinityz/BmSDK-AK/commit/b488c43a16d4ffd0cfdb6bdf38d8e5d0db15cfe3))
* Keep each mod's compile errors together and lock the reload timers ([d155674](https://github.com/XeTrinityz/BmSDK-AK/commit/d155674b362636951a135e3fef2fcdb52e5872fb))
* Keep the game running when a script component's OnDetach throws ([10bd9b5](https://github.com/XeTrinityz/BmSDK-AK/commit/10bd9b52ea6726ee2d7a7c8aaed7135dd85f6072))
* Keep the log sender per thread so background lines aren't given another mod's name ([c8d7c72](https://github.com/XeTrinityz/BmSDK-AK/commit/c8d7c72403bd83fd404f98da2c4eb0d91689622c))
* Leave out a redirect or component that can't be set up instead of half loading the mod ([b0618f3](https://github.com/XeTrinityz/BmSDK-AK/commit/b0618f3dc459fe26d95603a853d04bb8151a2d0e))
* Let the game path scroll sideways instead of wrapping ([100ed23](https://github.com/XeTrinityz/BmSDK-AK/commit/100ed23481ec931af1d647598dfe59d0dcf2644c))
* List scripts in folders under BmGame\Scripts so they can be turned off ([17f0bfa](https://github.com/XeTrinityz/BmSDK-AK/commit/17f0bfa16d0acfe1a9fb290386750f8b677003e3))
* Log the exception when a mod's own thread or timer closes the game ([67626a0](https://github.com/XeTrinityz/BmSDK-AK/commit/67626a007bbbeb6ca0799b7583c403034bc608a6))
* Make the Mods and Scripts folders at startup so a first mod loads without a restart ([84beadd](https://github.com/XeTrinityz/BmSDK-AK/commit/84beadd3d0bda6be763ba5d83da21936b11551a5))
* Notice when the game starts or closes instead of showing a stale Running ([3020191](https://github.com/XeTrinityz/BmSDK-AK/commit/30201911dd9e88e4828c955a99c44103701ce078))
* Put a mod back on fully when turning it off fails part way ([bafc6d1](https://github.com/XeTrinityz/BmSDK-AK/commit/bafc6d1fb6f8ec09745292f45c31d2624be0a8e0))
* Read mod.toml with a BOM or comments the same way BmSDK does ([24d786b](https://github.com/XeTrinityz/BmSDK-AK/commit/24d786b7e9c8046ece2b5c34cf5f59a78cdf00ab))
* Say so when the game exe isn't a supported build instead of crashing ([9c995d0](https://github.com/XeTrinityz/BmSDK-AK/commit/9c995d0a6ca79d0c823852541c01ed8759baa9f2))
* Say what is missing when a Game.Get call has nothing to return ([8c356e8](https://github.com/XeTrinityz/BmSDK-AK/commit/8c356e8136fbdca18f7a2f023e4d6700c5710c7c))
* Show the version from mod.toml as the one you have on Nexus ([d41a0bf](https://github.com/XeTrinityz/BmSDK-AK/commit/d41a0bf991e4ccb56d094d825c350192e02d4d56))
* Show what a script's constructor or static field threw ([190a2be](https://github.com/XeTrinityz/BmSDK-AK/commit/190a2be960ecb0aea079a9192ebbaa875c86cd84))
* Still offer the other dropped mods when one archive can't be opened, and ask to turn mods off before switching the game folder ([3869865](https://github.com/XeTrinityz/BmSDK-AK/commit/3869865208595823ac9e672d82f1869fd97fc70e))
* Turn the other mods back on when one can't be after playing without mods ([3e5c414](https://github.com/XeTrinityz/BmSDK-AK/commit/3e5c414ecc585dd9557775d2188ad80e1a9648f1))

## [0.26.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.25.0...v0.26.0) (2026-11-18)


### Features

* Show manager updates in Settings and check downloads against checksums ([d96915f](https://github.com/XeTrinityz/BmSDK-AK/commit/d96915fa92ef8beeac0f8407c94d560cd0ef7596))


### Bug Fixes

* Cap the on-screen error list at 30 lines ([9ae97df](https://github.com/XeTrinityz/BmSDK-AK/commit/9ae97dfdd9d7f2c693a3db2f500249d34210d393))
* Hide the browser right-click menu in release builds ([0f8154b](https://github.com/XeTrinityz/BmSDK-AK/commit/0f8154b162bf726c74ce48ed8928f61cc4ca979f))
* Keep edits, the saved list and old copies safe when the manager changes mods ([fa31caa](https://github.com/XeTrinityz/BmSDK-AK/commit/fa31caa74c7da2c6e2d80d0d395d930f9258575b))
* Keep mod project files out of ScriptsDev ([b1ee585](https://github.com/XeTrinityz/BmSDK-AK/commit/b1ee585d00ba42287352b564cf120391c66f8e8c))
* Pass every parameter to the original when a redirect runs it ([55c30f2](https://github.com/XeTrinityz/BmSDK-AK/commit/55c30f270e569648322f8b40d08689199fe0dbdf))
* Remove the light border Windows 11 draws around the window ([edde489](https://github.com/XeTrinityz/BmSDK-AK/commit/edde489f5cb7e288bcac9dfbc3cffc73a1b1a48d))
* Show a plain message when the host can't start .NET ([db6059b](https://github.com/XeTrinityz/BmSDK-AK/commit/db6059b8bb395088226c0fb926e2f4f606817c5a))
* Start the game when BmSDK.log can't be written ([ebbe13e](https://github.com/XeTrinityz/BmSDK-AK/commit/ebbe13e8e517396af54d1c5a2fded34b0376caf0))
* Use degrees for the camera pitch in the CameraScript sample ([962d51b](https://github.com/XeTrinityz/BmSDK-AK/commit/962d51bd3264965c163445a3938e09151c96bef4))
* Warn when a mod has no scripts folder ([52e2895](https://github.com/XeTrinityz/BmSDK-AK/commit/52e2895c61372b3ef6e98fa9a0e2add8c49c00fc))

## [0.25.0](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.24.1...v0.25.0) (2026-11-18)


### Features

* Replace the installer with BmSDK Manager ([49c4220](https://github.com/XeTrinityz/BmSDK-AK/commit/49c4220b75666fde66593c75e6ba624fac3fd678))

## [0.24.1](https://github.com/XeTrinityz/BmSDK-AK/compare/v0.24.0...v0.24.1) (2026-11-16)


### Bug Fixes

* Load a package again when an object it needs is gone ([3a4d6f7](https://github.com/XeTrinityz/BmSDK-AK/commit/3a4d6f7c40dba121e23f19d2f8f81156930d4878))
* Run the original when two redirects both call RunOriginal ([75341b2](https://github.com/XeTrinityz/BmSDK-AK/commit/75341b22578f2d1a51ffbc7398f4c7ca2350bf68))

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
