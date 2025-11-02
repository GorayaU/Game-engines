# In-Lab Assignment 3


### Name:
Udeyveer Goraya 100918410

### Project:
In this game the goal is to move around and kill the enemy cubes that spawn at random locations on the grid, you can move around using the controlls  
A - left  
S - Down  
D - Right  
W - Up  
LeftMouse - Shoot

### Diagram:
<img width="201" height="544" alt="image" src="https://github.com/user-attachments/assets/01fe102a-a298-483b-a8db-46ed3eae013d" />

### Reflection 
The enemy spawning system uses a observer pattern, when a enemy is killed it tells the factory by sending a event notification to spawn a new one.  
This is good because it makes it so the enemies doent need to have a direct reference to the factory, this also makes it easier to add new events on enemy death.

### References
https://docs.unity.com/en-us  

