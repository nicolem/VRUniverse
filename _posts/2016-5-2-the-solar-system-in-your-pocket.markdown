---
layout: post
title:  "VRUniverse&#58 The Solar System (and maybe more!) in your pocket!"
date:   2016-5-2
description:  "The end of the regular development of VRUniverse is approaching quickly. The app designed for google cardboard is becoming more and more polished and cohesive, with the different parts each team member developed fitting together exceedingly well, with most of the hoped for functionality being implemented. From the final menu to the scaled sun shown from each planet and the text boxes throughout the app, much has changed since the last update, and all for the better."
---

The end of the regular development of VRUniverse is approaching quickly. The app designed for google cardboard is becoming more and more polished and cohesive, with the different parts each team member developed fitting together exceedingly well, with most of the hoped for functionality being implemented. From the final menu to the scaled sun shown from each planet and the text boxes throughout the app, much has changed since the last update, and all for the better. 

<img src="{{ '/assets/img/blog2/main2d.png' | prepend: site.baseurl }}" alt="">

### Main Planet Views

Our project is now complete with the Sun, eight planets, and the dwarf planet Pluto.  Our outer views have models we purchased from the Unity Assets store.  We decided to purchase models because we wanted to focus on the functionality of the app instead of spending weeks developing the models ourselves.  The data for each model is from NASA surveys, and therefore scientifically accurate.  The New Horizons data for Pluto allows us to include the latest information for the whole solar system.  Adding in the extra models means that the app increased dramatically in size.  We decided to reduce the resolution of the model files to about a 10th of their original size.  The change isn’t noticeable on the small device screens or even on the larger computer monitors.  This dramatically reduced the total size of the app to 50 Mb, smaller than it was with just the original Sun and Earth models, and comparable to other apps available in the Google Play store.

The planets are sized at a relative scale, instead of being scientifically accurate.  This means Jupiter fills up your screen, but you can still see details on Pluto’s surface.  Each planet scene has the Sun on the opposite side.  The sun’s size is set to an accurate scale. Pluto is 40 times further away from the Sun than Earth, so in the Pluto scene the Sun is a tiny yellow dot in the distance.  In the Mercury scene the Sun is very close, almost as big as in the Sun’s own scene.

<img src="{{ '/assets/img/blog2/plutosun2d.png' | prepend: site.baseurl }}" alt="">

### Text Boxes and Fun Facts

### Molecules 
All planets now have a scene that shows some part of their molecular makeup! The inner planets were fairly straightforward, with their cores being mostly comprised of heavy metals like iron and nickel in either a solid or molten form. The molecules scenes were more difficult to implement for the outer planets (Jupiter through Neptune plus Pluto) due to the much lower knowledge base we have about these planets. 
The molecular scene of the sun shows both hydrogen and helium, with much more of the former. The amount of hydrogen in the sun is so much greater because the sun’s nuclear fusion is driven by the combining of four hydrogen molecules into one helium molecule. This process generates the heat and light we associate with the star in the form of energetic photons that are sent to all corners of the solar system. 

<img src="{{ '/assets/img/blog2/suninside2d.png' | prepend: site.baseurl }}" alt="">

Mercury, Venus, Earth, and Mars all have cores with very well known and very similar molecular makeups, making these molecular scenes the easiest to implement. The elements in the core remained very similar between them all, the main differences came in the molecules’ speeds which depended simply upon the state of matter in the core. Gaseous molecules move much faster than molecules in liquids, and molecules in a solid are almost completely stationary, and usually in some kind of a lattice formation.

<img src="{{ '/assets/img/blog2/mercuryinside2d.png' | prepend: site.baseurl }}" alt="">

For Jupiter and Saturn the molecular display ended up showing the layer of conducting liquid hydrogen surrounding the core of the planet rather than the actual core, which is thought to be comprised of solid material of some sort, but they are just too far away and too big for us to know for sure at this point in the exploration of the Solar System.  
The core of Uranus is composed mainly of chemical compounds like methane, ammonia, and water rather than singular elements like most of the planets, however these were approximated to singular spheres for each compound, which was explained in the text box associated with the molecule scene.

<img src="{{ '/assets/img/blog2/uranusinside2d.png' | prepend: site.baseurl }}" alt="">
 
Finally, both Neptune and Pluto have cores made up of what is most likely some kind of generic “rocky material” which was also approximated with a simple sphere. Unfortunately they are just too far away from earth to have sustained the same kind of intense and thorough study as the inner planets, though this level of observation is sure to come soon to all of the outer planets. 

<img src="{{ '/assets/img/blog2/neptuneinside2d.png' | prepend: site.baseurl }}" alt="">

Each planet has its own individual molecular scene associated with the main scene already in existence for each planet. The molecules are approximated using multiple particle systems within each scene. The particle systems are a game object within unity that emit a certain number of particles/second randomly either from the shell of a shape, or the center of said shape. The lifetimes of these particles can be adjusted, as well as color and size. The speed of each particle can also be manipulated, and the natural forces felt by molecules were attempted to be approximated within the particle systems as well. With all that can be done with the unity object of particle systems, these objects were used to model the complex interactions of molecules using the various ways the particles can be emitted, as well as the above possible manipulations of speed and force pertaining to each particle over its lifetime. When multiple particle systems work together, the chaotic looking result interprets well the concept of a gaseous, liquid or even solid planetary core at a molecular level.

### Menus
