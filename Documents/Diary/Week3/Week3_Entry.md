# Week 3

Looked into exsisting climbing/IK systems:

https://www.youtube.com/watch?v=jN0gBxd6IE0&t=22s : Provides excellent considerations about making an intuitive climbing system, and core principles.
## Considerations 

### Strength
To make responsive, have a physically based controlled, with uncapped max speeds. Use 1/x applied as drag
Should feel controlled at lower speeds, and unrestricted at higher speeds (controler speeds)
![image](https://github.com/user-attachments/assets/7b1475d8-2dfe-4bf1-b54b-055548ccdf79)
![image](https://github.com/user-attachments/assets/243ac228-944f-4bce-bdbf-c33a2375ada4)

### Collisions and interactions
Manually moving feet CAN feel clunky. Only allow the head and controllers to collide (prevent getting stuck).

### Mounting Objects
Automate the "standing up" system. Automatically lower legs when pulling up using a raycast drawn down from the head. Prevents immersion breaking, whilst minimizing input.

### Walls should feel tangible 
Pushing against a wall should push back the head and hand controllers to mimic a reaction force. Try to prevent the head clipping

## Debugging in VR
https://www.youtube.com/watch?v=Pi4SHO0IEQY&list=PL1PIWPRFeCKVxSOFm3q11omTWqQk4t3ij&index=2
Debugging can be a pain -> implement an in-game console to view the output of the console.
