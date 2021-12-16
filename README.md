## Individual Project

**Overview**
The project is a simple single player game. The gamer can use the two sticks to hit the cube flying toward the players. 
When the user hits the cube, the cube will break into several pieces of different colors. This is designed 
for users who wish to release their anger and pressure in the virtual world. They can use the sticks to destroy the huge amount of cubes flying toward them.

**Design Purpose**
I wish users could release their anger by hitting the cubes will flying to them. The explosion of object into pieces can relief the users' pressure. 

**Goals:**
* Finish the explosion effect
  * Create a separate but identical object with rigidbody built in.
  * Write a script to make the original one destroyed and prop up the post-explosion model. 
* Add the snow mountain to the back ground of my personal project.
* Adjust the position of object generator to avoid damage from collision while flying to the users.
  * Modify the size of the flying object to make them easy to touch without doing too much effort.
  * Improve the layout of each generator.
* Finish the flow-control system
  * Adjust the frequency of generating object to avoid too much object in a scene, which could cause burden to the graphic card unit.
  * Improved the flow control system using coroutine to make the interval between the object generation more reasonable.
* Destroy the object after the user hits them.
  * Give the flying cubes a life-cycle, they will disappear shortly after they get hit by a stick.
* Finish the testing to make it more playable.

I have finished the explosion special effect of the box using coroutine.
I have finished design and testing the flow-control system
I have added the snow mountain and sea water to the background of the scene.
I have finished the object life-cycle using coroutine to destroy them after get get hit.
I have finished all the testings of the project.

**Goal Accessment**
I haved finished the game from the start to the end. The cubes can now be generated from several hidden(invisible) generators in the scene and flows toward the users. The users
are able to grab sticks to hit the the flying cubes when their sticks collide with the cube. The cube will explode into three pieces, white, blue and red. The cube will disappear once 
they collide with the sticks. When the user miss the target, the box will collide with an invisible wall after the XR rig and disappear 3 seconds after the explosion happen. The game
is playable. Everything is successful. Goal is completed.

**Design**
The box: I initially decided to make it similar to <<Fruit Ninja>>'s style. However, after I experimented with a tiny demo, I felt that the Fruit Ninja is particularly designed for 
the 2D users. However, VR is 3D, so I must change my all game elements to 3D to demonstrate the property of VR. I think it is very natural to think using colliders to trigger the explosion.
The explosion is triggered when the cube first hits the colliders of other bodies. The original cube will be destroyed. A new cube consists of three separate rectagular prisms will 
be instantitated. A little bit of explosion force was added to the trigger to make the hitting much more realistic. The problem did occur. The capsule collider cannot hit the cube.
After debugging, I finally found out that the sequence of adding RigidBody was incorrect.
Finally, the sticks can properly interact with the cubes.

The generators: I set about 11 cube generators in the game. Each of them will generate a cube every 3 seconds. The cube will be pushed by a constant force of 3 newton toward the 
users' position. They are placed by 4 layers of layout. Each layer consists of three generators. They will routinely(3 cubes per three seconds) generate the cube flying toward the user.
The functionality is implemented by coroutine of C#. 

The flow control syste: As users enjoy the game, the cubes are being continuously generated. If it is not regulated, the number of object in the scene will soon surpass what the memory
can hold, which could cause the out of memory of VR device. To solve this overflow problem, I added a detection mechanism in the game. If the cube break into pieces, which is guaranteed to happen,
the broken pieces will be destroyed by a coroutine after 3 seconds. Also, if the number of cubes in this scene exceeds 34, the next time that generator generates the object will be 20
seconds instead of 3 seconds after. This generally controlled the size of total number of objects in a scene in a reasonable range without letting users to wait for too long for next round.

The landscape: I have installed the model of snow mountains and see water. The users will feel themselves playing this game in the North Europe. This will bring them good mood, which is 
another purpose of designing this game.

Overall, the game is completed by this moment. 

