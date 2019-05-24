# FightAgent

**FightAgent** is an AI learning agent for a 2D game that uses Machine Learning to learn to succesfully play the game and complete its objective.

## Project Overview

This project focuses on implementing machine learning in a simple fighting game that is developed using the Unity engine. The AI agent is trained to complete the objective of the game, with the help of **Unity3D's Machine Learning Agents Toolkit** and **Tensorflow**. 
The game would have had generic actions such as, move forward, move backward, jump, punch, kick, block , but due to difficulties with external libraries and deadlines the game had to be made much much simpler. Currently the agent learns to play against a rendomly generated "enemy", based on trial and error.

## Key tools and components used 

* Unity engine
* Unity ML Agents Toolkit
* Tensorflow GPU
* Anaconda (Python3)
* Nvidia CUDA toolkit (Optional unless, using GPU training)
* Nvidia cuDNN library (Optional unless, using GPU training)

## Relavant Info

**All the code that i have worked on is in the *FightAgent* folder**, the *ML-Agents* folder is acquired from Unity3D, the scripts inside that folder are necessary to code the agent.

From here on out i will only refer to my own work found in the *FlightAgent* folder unless explicitly stated.

There are 3 different scripts each for a different reward system that is used to train the agent. The best reward system for this particular game is *FightAgentCase3.cs*, there are other cases with slightly different reward systems but this one resulted in a higer success rate. More details on the reward systems and code can be found in the project report in the "Evaluation" section and "Implementation" section, respectively.
This project was my final year dissertaion for my honours degree. Although i stopped here, there is room for a lot more improvement and upgrades in the future.

## Setup and References

All the steps needed to install and set up the Unity ML Agents Toolkit, can be found on Unity-Technologies' ML-Agents repository [here](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/ML-Agents-Overview.md "ML-Agents repository"). 
There is more in depth information on the toolkit and its key components in the same repository, I would recommend giving it a read.    

All the sources used are referenced in the project report. 



