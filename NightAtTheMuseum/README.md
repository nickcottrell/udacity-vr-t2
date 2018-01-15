# Night at the Museum

## Notes on the process

### Purpose
The purpose of Night at the Museum is to help people understand the different use cases of VR. It does this by showcases those topics from within a VR experience. Users are transformed to different settings that each focus on a different flavor of the industry. The idea is to provide an immersive, engaging and performant experience. Also since VR covers so many items, the intent is that the information is presented in a clear and consistent manner. Hopefully users will come away from this experience with a more broad sense of how VR can be useful--It's not just about games! This project covers several topics, including:

* Journalism
* Social VR
* Virtual Tourism
* Architecture
* Medical

### Persona
The persona for this project was very similar to the first term 2 project, but this time, the idea is to focus on someone who is interested in VR and wants to dive deeper into what it could be used for. This idea was still that this should be designed for a relative beginner and should take extra care in making sure this person has a comfortable, engaging experience. The intent of the project is to help make a good impression for VR in general and help provide a good overview of various aspects of the industry.

![Persona](/NightAtTheMuseum/img/VR-persona-NATM.jpg)

### Concept & Grayboxing
The first step was to setup the project, and get the basic mechanic working. For this experience, there will need to be clickable elements that will need to take the user to an immersive scene. From within the immersive scene, the user will see images, hear audio, and read text to provide educational content.

To kick off the project, I got some basic working elements put together before implemented a full environment. Once that stuff was working, I deployed to my phone.

![Basic UI](/NightAtTheMuseum/img/sketches.png)
![Basic UI](/NightAtTheMuseum/img/graybox-lobby.png)
![Basic UI](/NightAtTheMuseum/img/graybox-booth.png)

### User Testing
After I got a graybox prototype complete, I completed a user test. The test was to drop the user in a basic lobby and have them click on the various booths to enter each photosphere. The basic idea was to get insights about navigation, layout and general feel of the direction.

![User Testing](/NightAtTheMuseum/img/user-test.png)

### Lessons Learned from User Testing
During the first round of user testing, I got the following feedback.
* "It made me dizzy when I looked down and didn't see a solid floor"...referring to 360 photosphere
* "How do I get back to the lobby?"

Based on that, I decided to make the following changes:
* Add a consistent solid ground to the 360 photoshperes
* Adjust the position of the back button so it's visible on load

### Adding the theme
To keep it simple and performant, I wanted to keep the theme as a pretty straight forward art gallery look. The idea is that the background can contain some white walls with light beams projected on them for a dynamic, yet not distracting background. For the most part, the colorful floating orbs are enough to focus on.

![User Testing](/NightAtTheMuseum/img/art-concept.jpg)

For consistency I carried the floor texture over from the gallery to the 360 image base.

I used a floor texture from this [asset bundle](https://assetstore.unity.com/packages/3d/environments/showroom-environment-73740).

I got the velvet rope prop from this [asset bundle](https://assetstore.unity.com/packages/3d/props/interior/gallery-showroom-environment-92146).

### Final Project
Here's a walk through of the final app. As you can see, the setting starts off in a gallery setting. As the instructions state, users click on the spheres in order to learn more about the impact VR is having on various industries.
<br>
[![App Walkthrough](https://img.youtube.com/vi/qjHm1dLnGeM/0.jpg)](https://www.youtube.com/watch?v=qjHm1dLnGeM)

### Conclusion
The final project provides a good intro into the kinds of things you can do in VR. Virtual Reality isn't just about games. It's about connecting with friends, empathizing with people, and connecting with parts of the world that you don't normally have access to. 

Virtual Reality also has the power to make people more productive. The examples here for that include advancements in Architecture and Medical fields. In Architecture it's about helping people understand the outcome of a long process. In Medicine, it's about simulating exerience for training, and even for modifying behaviors and aleviating trauma. Beyond that, VR will help provide new ways to connect with and understand information.


This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.2.0f3
- GVR Unity SDK v1.60.0
- iTween v2.0.7


qjHm1dLnGeM



