# Puzzler

## Notes on the process

### Purpose
Puzzler is a game designed for new VR users to get a sense for basic gaze-based controls. The purpose is to have a comfortable user experience and hopefully a positive impression on VR as a way of experiencing media.

### Persona
Developed a rough persona to map to this project. The idea is that this should be designed for a relative beginner and should take extra care in making sure this person has a comfortable, engaging experience. This project should help make a good impression for VR in general as well as for the game itself.

![Persona](/Puzzler/img/vr-persona-01.jpg)

### Getting Started
The first thing I did was opened the starter project, got everything up and running properly. I deployed to my phone and verified that it deployed properly.

![In the editor](/Puzzler/img/editor.png)
![In the headset](/Puzzler/img/graybox-prototype.png)


### Grayboxing
The idea here is to get all working elements working before I actually decide on a theme and or polish the elements. First, I want to make sure the game works with the timing. By keeping all elements basic and non-styled, I am able to focus on the basic interactions and timing.

![Basic UI](/Puzzler/img/basic-ui.png)

### Conceptual Art
Before actually applying the art to the scene, I want to look a couple of different variations based on the art that I will have access to in the Unity Asset Store. I put together some moodboards on some possible themes. When I do the first round of user testing, I'll use the moodboards to guage interest from others to helpe determine which theme I might go with.

![Wizard Laboratory](/Puzzler/img/ConceptArt-01.jpg)
<br>
<br>
![Alien Crash Site](/Puzzler/img/ConceptArt-02.jpg)


### User Testing
After I have a working graybox prototype and art theme moodboards, I am now ready to do a round of user tests. The main thing I'm trying to guage is interest in the art and story as well as get feedback from the general mechanics, timing and scale of the game.

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

Overall, I think the user testing provided insight and helped me create a better game.

### Adding the theme
Based on the input from the user testing, I think this theme will work the best. To create this theme, I combined the following Asset bundles.

From there I used X, Y and Z pieces to help tell the story.

Once the main art was in place, I made sure everything worked and was performant on my phone.

I made this performance tweak based on the initial run.

Next I developed the designs for the UI canvas elements. I used X, Y, and Z elements to incorporate the theme.

### Final Project
[![App Walkthrough](https://img.youtube.com/vi/dQw4w9WgXcQ/0.jpg)](https://www.youtube.com/watch?v=dQw4w9WgXcQ)

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.2.0f3
- GVR Unity SDK v1.60.0
- iTween v2.0.7



