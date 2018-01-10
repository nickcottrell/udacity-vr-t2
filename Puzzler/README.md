# Puzzler

## Notes on the process

### Purpose
Puzzler is a game designed for new VR users to get a sense for basic gaze-based controls. The purpose is to have a comfortable user experience and hopefully a positive impression on VR as a way of experiencing media.

### Persona
First, I developed a persona to for this project. The idea was that this should be designed for a relative beginner and should take extra care in making sure this person has a comfortable, engaging experience. The intent of the project is to help make a good impression for VR in general as well as for the game itself.

![Persona](/Puzzler/img/vr-persona-01.jpg)

### Getting Started
The first thing I did was opened the starter project, got everything up and running properly. I deployed to my phone and verified that it deployed properly.

![In the editor](/Puzzler/img/editor.png)
![In the headset](/Puzzler/img/graybox-prototype.png)


### Grayboxing
The idea here was to get all working elements in before I actually decided on a theme and or polished the elements. First, I wanted to make sure the game works with the timing. By keeping all elements basic and non-styled, I was able to focus on the basic interactions and timing.

![Basic UI](/Puzzler/img/basic-ui.png)

### Conceptual Art
Before actually applying the art to the scene, I wanted to look a couple of different variations based on the art that I will have access to in the Unity Asset Store. I put together some moodboards on some possible themes. For the first round of user testing, my idea was to use the moodboards to guage interest from others to helpe determine which theme I might go with.

![Wizard Laboratory](/Puzzler/img/ConceptArt-01.jpg)
<br>
<br>
![Alien Crash Site](/Puzzler/img/ConceptArt-02.jpg)


### User Testing
After I worked with the graybox prototype and art theme moodboards. Next, I was ready to do a round of user tests. The main thing I tried to guage is interest in the art and story as well as to get feedback from the general mechanics, timing and scale of the game.

![User Testing](/Puzzler/img/user-testing.png)

### Lessons Learned from User Testing
During he first round of user testing, I got the following feedback.
* "signage pretty straight forward"
* "simple and easy to navigate"
* "movement speed was comfortable"
* "game contained no instructions" 
* "it was a little bit confusing as to whether i was clicking or if it was the computer"
* "it wasn't clear when their turn ended and my turn began"
* "maybe have a sign that says 'watch the pattern and copy it' or something like that"
* "maybe the color could be different when i click it versus when the computer clicks"

Based on that, I decided to make the following changes:
* Add a sign before the user starts playing that helps explain the rules of the game
* Add a sound at the beginning and end of the computer pattern
* Add a error sound or some feedback when you get it wrong.
* Limit the users input to 5 elements and then playing a sound to indicate the turn is over (if needed)
* Change the color of the user input versus the computer pattern

I also got feeback on the themes and decided to go with the Alien Crash scene because it seemed more original than the Wizard theme.

I sketched out some ideas before making the fixes and adding the art.

![Sketches](/Puzzler/img/sketches.png)

Overall, I think the user testing provided insight and helped me create a better game.


### Adding the theme
Based on the input from the user testing, I think this theme will work the best. 

To create this theme, I combined the following Asset bundles:
* Low Poly: Desert Pack by AxeyWorks
* Shanty Shack by Jason Wong
* Low-Poly UFO by MakeShift

From there I tied the pieces together to help tell the story. The idea is that an alien ship crashed and the orbs are somehow linked to it. 

Once the main art was in place, I made sure everything worked and was performant on my phone.

### Final Project
The final project shows the basic game mechanic playing along side a theme. The user is introduced to the story by seeing the crash to the left. When they select the START button, they go into the shack, where they discover the orbs and the game mechanic. When the user solves the puzzle, they make their way out the back window to see the success UI.
[![App Walkthrough](https://img.youtube.com/vi/ZZD_BoZp8dQ/0.jpg)](https://www.youtube.com/watch?v=ZZD_BoZp8dQ)

### Conclusion
This project represents how to thoughtfully approach the design of a VR experience. There are many considerations that have to be made about user needs, comfort, control, and comprehension. I was able to test my ideas with users and helped provide rationale for making the game work better.

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.2.0f3
- GVR Unity SDK v1.60.0
- iTween v2.0.7



