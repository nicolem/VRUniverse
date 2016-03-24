---
layout: post
title:  "To the Virtual Universe and Beyond!"
date:   2016-3-24
---

<h4>SUN: And additional models!</h4>

So you want to make a space app! Cool. sounds like you’ll need to slap some images of planets on a phone screen and you’ll be fine, right? Not exactly.  We wanted to make a 3D tour of the solar system, and 3D means you need 3D models, not just images.  Luckily for us NASA has great quality images of the planets that an artist has combined into beautiful 3D models compatible with Unity, our editor of choice.  So now we can make up some scenes with these scientifically accurate models for user viewing pleasure.  Except they don’t actually look 3D.  We decided to use Google Cardboard as a 3D viewer for our app.  All you do is add in the Cardboard API to your Unity project, and it changes your single camera into stereo cameras.  When you see these two images side-by-side in the Cardboard viewer you see a 3D planet floating in space.

This API doesn’t come without bugs, though.  We’ve had to tweak the distances between the cameras and the planet to stop the planet from glitching as you can see below.
<img src="{{ '/assets/img/touring.jpg' | prepend: site.baseurl }}" alt=""> 

We are also working on user controls because, unlike any other platform, android doesn’t have a mechanism in place to count the number of taps on the screen that happen. Our original user controls involved distinguishing single and double taps.  Our new plan involves the user clicking on or away from a planet.

<h4>Transitions: Change We Can Believe In</h4>

Our application is composed of a variety of essential Unity scenes (menu, Sun, Sun interior, Earth, etc.). In order to link these scenes together and provide for a cohesive user experience, we must implement smooth and intuitive transitions between them. These should allow users to navigate between the planets’ interiors and exteriors, as well as switch between planets. 

The Google Cardboard can only take in user input in a few forms: direction of the user’s gaze pressing the button on the side of the Google Cardboard, which results in a screen taps. With only this data there are a few options for transitions schemes between various scenes using Unity buttons and scripts.

Our app has been emitting a bright white flash on certain Android devices when we developed a simple script to transition between scenes. Because smoothness of transitions is a large concern, we want to eliminate this. This can be done by fading into and out of each scene rather than displaying as soon as the scene can be rendered. Thus far we have been experimenting with a Unity component which blocks the user’s vision, persists between scenes, and transitions between opaque and transparent over a given timescale. We will need to experiment with parameters for this component in order to ensure that the bright flash is eliminated.

<h4>Menu: I can show you the world.. And more!</h4>

The menu features a point and press design that makes it easy for users to navigate between planets. Right now we have a basic menu with rectangular buttons that will take you to your desired planet. Pressing the button on the cardboard viewer again will zoom you into the planet or star, and a final press will take you back to the menu. Our future plans for the menu is to make the buttons look like planets. We would also like to make the overall layout more fun to look at for users while still maintaining intuitive actions. We want to add new features such as settings button to allow users to adjust sounds, toggle 3D mode, and whether they would like to see popups and other features.


<h4>Zooming: Molecules are FUN! </h4>

Realistically portraying molecules is difficult to do because of the multitude of forces that affect their movements and positions. A separate scene was used to portray the interiors of the sun and earth, and was linked to the main sun and earth scenes to allow access to the interior views. The particle system component in Unity allows a group of identical particles to be mass created and distributed which takes care of some of the difficulty in creating a complex system of molecules. The intricate interactions between the molecules in the sun can be approximated using particle systems with some amount of intrinsic velocity and maximum particle numbers. Currently the interior of the sun shows the center of the sun, both hydrogen (white) and helium (pink) both in gaseous form. A stretch goal at this point would be to illustrate the fusion of hydrogen into helium. The interior of the earth also needs to be added, as well as those of the additional planets. Additionally, scenes will be added that show the layers of each planet, and if time remains, the planet at the particle level. 
