# A* Pathfinding Project

Lightning fast pathfinding for Unity3D. Whether you write a TD, RTS, FPS or RPG game, this package is for you. With heavily optimized algorithms and a large feature set but yet simple to use, you will be able to make those bots a bit smarter in no time.

[Pathfinding](https://arongranberg.com/astar/)

# Tweening

Inbetweening, also commonly known as tweening, is a process in animation that involves generating intermediate frames, called inbetweens, between two keyframes. The intended result is to create the illusion of movement by smoothly transitioning one image into another.

[Tweening](http://dotween.demigiant.com/)

# Ease (SetEase)

`SetEase(Ease easeType \ AnimationCurve animCurve \ EaseFunction customEase)`

Sets the ease of the tween.

If applied to a Sequence instead of a Tweener, the ease will be applied to the whole Sequence as if it was a single animated timeline. Sequences always have Ease.Linear by default, independently of the global default ease settings.

You can pass it either a default ease (Ease – to see how default ease curves look, check out [easings.net](https://easings.net/)), an AnimationCurve or a custom ease function ([see example](https://forum.unity.com/threads/dotween-hotween-v2-a-unity-tween-engine.260692/page-40#post-2376683)).
Additionally, the following optional parameters can be set: they work only with Back and Elastic eases.

**NOTE:** Back and Elastic eases (meaning any ease that goes below or beyond the start and end values) don't work with paths.

# Callbacks (SetEase)

`OnComplete(TweenCallback callback)`

Sets a callback that will be fired the moment the tween reaches completion, all loops included.

`OnStart(TweenCallback callback)`

Sets a callback that will be fired once when the tween starts (meaning when the tween is set in a playing state the first time, after any eventual delay).

# Web Request

Make a request to a uniform resource identifier (URI).

[Weather API](https://openweathermap.org/api)

[API Keys](https://home.openweathermap.org/api_keys)

[JSON](https://openweathermap.org/current#current_JSON)

[Weather Conditions](https://openweathermap.org/weather-conditions)

# Design Patterns

[Game Programming Patterns](https://gameprogrammingpatterns.com/contents.html)

# Singleton pattern

In software engineering, the singleton pattern is a software design pattern that restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system.

In mathematics, a singleton, also known as a unit set, is a set with exactly one element. For example, the set {null } is a singleton containing the element null.

# Panel UI

If you add to game an object `UI panel`, automatically is adding to the game an object `EvenSystem`, witch has the following error:

```diff
- InvalidOperationException: You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings.
```
Click on button `Replace With InputSystemUIInputModule` to solve this problem.

![plot](./Images/Error.jpg)

# Audio resources

[Free sound](https://freesound.org/)

## Possible Errors

```diff
UnityEngine.AudioSource.PlayOneShot (UnityEngine.AudioClip clip) (at <7117d168a9ec4e518e0de7d9c98bd09a>:0)
SoundManager.PlayShoot () (at Assets/Scripts/Singleton/SoundManager.cs:32)
PlayerController.OnFire () (at Assets/Scripts/Player/PlayerController.cs:32)
UnityEngine.InputSystem.LowLevel.<>c__DisplayClass7_0:<set_onUpdate>b__0(NativeInputUpdateType, NativeInputEventBuffer*)
UnityEngineInternal.Input.NativeInputSystem:NotifyUpdate(NativeInputUpdateType, IntPtr)
```

To solve the problem add an `AudioSource` to the `SoundManager`.

![plot](./Images/Error1.jpg)