You are required to design a C# program to parse notification titles and assign them to different notification channels. Notification titles consist of multiple tags, each enclosed in square brackets and separated by square brackets. Each tag represents a different notification channel, which may include Backend (BE), Frontend (FE), Quality Assurance (QA), and Urgent (Urgent).

Your program needs to analyze the title, identify relevant tags associated with notification channels, and list those notification channels. Note that tags may appear in different orders and could include other irrelevant content.


Here are a few examples: 

Case 1 

- Input "[BE][FE][Urgent] there is error"
- Output: "Receive channels: BE, FE, Urgent"

Case 2

- Input: "[BE][QA][HAHA][Urgent] there is error"
- Output: "Receive channels: BE, QA, Urgent"
