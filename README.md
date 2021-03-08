 ## Table of Contents 
 1. [Why Insectic?](#head)
 2. [What is Insectic](#head2)
 3. [Case Use Diagram](#head3)
 4. [ERD](#erd)
 5. [Draft WireFrames](#head4)
    1. [Dashboard page](#head41)
     
    3. [Analytics page](#head42)
    4. [Archive page](#head43)
    5. [Ticket Submission page](#head44)
    
    7. [Contact page](#head45)
 6. [User Stories](#head5)
 7. [Use Cases](#head6)
 8. [Requirements](#head7)
 9. [Test Table](#head8)
 10. [Current Issues](#head9)

***
<a name="head"></a>
 # <p align ="center"> :beetle: Why Insectic? :beetle: [:arrow_up_small:](#table-of-contents) </p> 

Insectic is a side project I am working on to help viuslize one of the 4 pillars of work; Unplanned work. This idea came to me after reading <i>The Phoenix Project</i> I wanted to follow along with Bill and Patty and see if I could create an application that would of helped visualize, track, and streamline the completion of unplanned tasks and work. 

<a name="head2"></a>
## <p align ="center"> :beetle: What Is Insectic? :beetle: [:arrow_up_small:](#table-of-contents) </p>
Insectic will be an interactive bug/patches tracking web application that will forcus on the unplanned work aspect of DevOPs. This Web application will allow Managers to track current items being worked on with detailed statistics to help locate bottle necks. Team leaders will be able to utilize this tool to task out team members, track team progress and will be able to see team analytics to better articulate the needs of the team to the department manager. 
***
<a name="head3"></a>
### <p align="center"> :page_facing_up: [Case Use Diagram](https://github.com/Darius-D/Insectic/blob/main/CaseUseDiagram.jpg) :page_facing_up: </p>
***
### <p align ="center"> ERD [:arrow_up_small:](#table-of-contents) </p>
***
<a name="erd"></a>
![](img/myERD.jpg)

***
<a name="head4"></a>
###     <p align ="center"> DRAFT WIREFRAMES [:arrow_up_small:](#table-of-contents) </p>

***
<a name="head41"></a>
###   <p align ="center"> Dashboard/Home Draft [:arrow_up_small:](#table-of-contents) </p>

<img src="https://github.com/Darius-D/Insectic/blob/main/img/dashboard2.JPG" width="1000" height="600">



<a name="head42"></a>
###  <p align ="center"> Analytics Page [:arrow_up_small:](#table-of-contents) </p>


![](img/Analytic%20page.JPG)

***
<a name="head43"></a>
###   <p align ="center"> Archives Page [:arrow_up_small:](#table-of-contents) </p>

![](img/Archives.JPG)

***
<a name="head44"></a>
###   <p align ="center"> Ticket Submission [:arrow_up_small:](#table-of-contents)  </p>


<p align="center">  
  
  <img src="https://github.com/Darius-D/Insectic/blob/main/img/ticket%20submission.png" width="1000" height="600"></p>
  
***
<a name="head45"></a>
###   <p align="center">  Contact Page [:arrow_up_small:](#table-of-contents) </p>

<a name="head45"></a>
![](img/Contact.JPG)

***
<a name="head5"></a>
### <p align ="center"> User Stories [:arrow_up_small:](#table-of-contents) </p>

1. As a Department Manager, I need to create “tickets” when ever a problem is detected in our process, so that we can visualize the bottleneck and common trends. 
2. As a Department Manager, I need to see the analytics of all the tickets in our system so that I can provide detailed reports to the CEO. 
3. As a Team lead, I need to be able manage my team assign them to tasks so that I can provide the Department Manager with daily status updates. 
4. As a Team Members, I need to be able to submit tickets for issues encountered with a detailed description and categories so that my team lead can articulate our current issues and progress with the Department Manager

***
<a name="head6"></a>
### <p align ="center"> Use Cases [:arrow_up_small:](#table-of-contents) </p>

* Given a new user
When user fills out application
Then assign values to new user object

* Given a user discovers a reportable issue
When all required forms are filled properly, 
Then create a ticket object and store the data.

* Given a ticket number 
when a user desires to update a ticket
Then pull ticket data and allow comments to be added and update database. 

* Given a ticket number, 
When a team member desires to close a ticket, 
Then query ticket and change status to pending closure and alert Department Manager.

* Given a ticket number, 
When a Department manager desires to close a ticket, 
Then query ticket and change status to close to add to archives.

* Given a Ticket ID
When user wants to view the ticket
Then populate the ticket into a table.

* Given a filtering condition, 
When user wants to pull analytics, 
Then generate a query that outputs values to display the count of all tickets by category, subcategory.

* Given a user ID
When a user needs to be assigned to a group
Then populate drop by selection to select groups available and update user’s group in DB.

*** 
<a name="head7"></a>
### <p align ="center"> Requirements [:arrow_up_small:](#table-of-contents) </p>

| Requirement ID | Requirement Description | Test Method | Test ID |
|:-------------|:------------------:|:----------: |:-----------:|
| 1 | The system shall create a user account with all required fields filled. | Analysis | 100 | 
| 1.1 | The system shall allow github authentication. | Analysis | 101 |
| 2 | The system shall display the users name and roles on all pages | Inspection | 200|
| 3 | The system Shall create unique ticket objects for each ticket submitted | Test | 300 |
| 3.1 | The system shall make a unique ticket ID for every ticket creation | Test | 301 |
| 3.2 | The system shall store all attributes of the ticket. | Test | 302|
| 4 | The system shall provide Department managers with Analytics for the whole company | Demonstration | 400 | 
| 4.1 | The system shall provide Department managers with Analytics for the whole company | Demonstration | 401 |
| 4.2 | The System shall provide the Team Leaders with analytics for their team | Demonstration | 402 |
| 4.3 | The system shall provide Team members with only their analytics. | Demonstration | 403 |
| 5 | The System shall archive closed tickets | Test |500|
| 5.1 | The System shall only allow Department managers to close tickets | Demonstration | 501 | 
| 5.2 | The System shall provide users the option to place ticket in pending close status | Demonstration | 502 |
| 6 | The System shall allow Department managers to move team member groups around | Demonstration | 600 |

***
<a name="head8"></a>
### <p align="center"> Test Table  [:arrow_up_small:](#table-of-contents) </p> 

| Test ID | Requirement ID | Test Prodedure | Current Status | TimeStamp |
|:--------|:--------------:|:--------------:|:--------------:|:---------:|
| 100     |     1          | Fill out form on page and verify model biniding occured and stored the values toa new user object |:red_circle:|TBD|
| 101     |     1.1        | Utilizing GitHub authentication, ensure new user object is created and values are stores in the DB |:red_circle:|TBD|
| 200     |      2         | With seveal users created in multiple roles, verify all pages render appropriate headers |:red_circle:|TBD|
| 300     |      3         | Upon creation of a ticket verify ticket values are unique utilizing test method |:red_circle:|TBD|
| 301     |       3.1      | Upon creation of a ticket verify ticket values are unique utilizing test method |:red_circle:|TBD|
| 302     |      3.2       | Upon creation of a ticket verify all NOT NULL fields are assigned values in the ticket table on server|:red_circle:|TBD|
| 400     |      4         | Inspect the Analytics web page ensuring data values are correct and match data in the server |:red_circle:|TBD|
| 401     |      4.1       | Utilizing a department Manager assigned user account, verify detailed analytics page displayes correct informtaion |:red_circle:|TBD|
| 402     |       4.2      | Utilizing a Team Leader assigned user account, verify detailed analytics page displayes correct informtaion |:red_circle:|TBD|
| 403     |       4.3      | Utilizing a Team Member assigned user account, verify detailed analytics page displayes correct informtaion |:red_circle:|TBD|
| 500     |       5        | Utilizing a Department manager role user, chnage an open ticket to closed and verify status in date base has been changed |:red_circle:|TBD|
| 501     |       5.1      | Utilizing any role besides Department Manager role, enusre close ticket is not a drop down option |:red_circle:|TBD|
| 502     |       5.2      | Utilizing any role besides Department Manager role, enusre pending close ticket is a drop down option|:red_circle:|TBD|
| 600     |       6        | Utilizing a Department Manager role user attempt to change user permissions |:red_circle:|TBD|
   
***
<a name="head9"></a>
### <p align="center"> Current Issues </p>

| Problem ID  | Problem Description | Solution| Date|
|:---:|:---:|:---:|:---:|
|01|After Creating my layout for my views, the taxtarea input on the ticket page expands out of the container when the browser is less than 500px. |I reconstructed the webpage utilizing Grid in the main content space. The web page now uses several media queries to hide several tags at various lengths and with the utilization of grid has become more fluid.  | March 7, 2021 |
    
    
