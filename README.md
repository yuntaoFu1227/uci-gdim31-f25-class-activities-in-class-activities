# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
When the cat moves, the camera stays in place because it's no longer a child of the cat.
### W2
The r, g and b variables are floats because their values are decimals between 0.0 and 1.0.
The _bounce variable is an int because it counts how many times the ball bounces.
The error showed me that I was using the wrong operator. I need use -=.
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
### W3
Activity 1: Methods Discussion
Table #: 3
1. GetResponse
- Parameters: int friendshipLevel, bool knowsSecret
- Return type: string, the character's dialogue response.
2. SetLightDimness
- Parameter: float sanityLevel (0-100)
- Return type: void, because the method changes the light directly.
3. DidPlayerHitBeat
- Parameter: float keyPressTime
- Return type: bool, indicating whether the player hit the beat accurately.

Activity 2: Components & Classes Metaphor
A class is like a blueprint for a house. The blueprint describes what a house can have and do, but it is not itself a house in the scene. A Component is like one actual house built from that blueprint. Member variables are the house's traits, such as its color or number of floors. Methods are the actions it can perform, such as opening a door or turning on a light. Multiple houses can be built from the same blueprint, just as multiple Components can be created from one class.

Activity 3: Methods Coding Activity
The ball get extremely bright because their color values are multipulied by 1.5 each time they bounce fast enough. As they keep bouncing, the color values increase, making the balls brighter and brighter. 
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
###W4
Table# : 3
1. I added Rigidbody components to the Soccerball and the Cat so that they can interact with physics. I enabled Is Trigger on the Goal so the ball could pass through it while still detecting when a goal was scored, And I kept Is Trigger unchecked on the Cat and SoccerBall so they could physically collide with other objects.
2. I forgot to add Bounce off Wall(Script) to SoccerBall. After making these changes, I tested the game again.
