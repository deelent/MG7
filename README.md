# MG7
## Devlog
1. Firstly, the TreeOfBirds class needs to be a component of the Tree gameObject and so when I declare the class, I list it as a monoBehaviour because of this and also since it gives access to helpful methods like Update() that we will use later. We create an array of _birds gameObjects and allow it to be edited in the inspector so I can add the birds into the array manually but also to set what it sees as the player in order for them to pop up when the player gets close. The interact distance is just a float variable that is measured in the code to set the birds active when close enough and there is a transform for the player so that the birds can tell where they are. All of these are private since they are variables and should not be messed with since we don't want them changed. As for the Update() method, I use an counter in order to get the birds in the _birds array and have them constantly measuring the distance between the player to become active when the player is within range which allows them to both pop up and track the player when they're carrying a seed.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
