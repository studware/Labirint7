
# Course Project
_Web applications with Node.js_

## Team "Freedom"
*************************************************
Cooking e-Web Application is a standard Web application developed by Team "Freedom" as part of the "Web Applications with Node.js" course at Telerik Academy 2016 - Spring.

##Team
| Nickname  | Name |
| ------------- | ------------- |
| IvanAngelov  | Иван Ангелов  |
| todor_ia  | Тодор Арабаджиев  |
| dushka.dragoeva | Душка Драгоева  |
| Azonic  | Васил Пенев  |
| Ellapt  | Ангела Тенева  |

##Application Desription 

The main purpоse of the application is to help the user easy to find cooking recipes and interesting articles on food topics. Paging and well organized, structured functionality allow the user to easily navigate around the application. He can easy find fantastic gourmet recipes, simple or sophisticated, then label the best ones as favorite, and even share them with friends via Facebook.
The "Cooking e-Web Application" was designed and implemented using [Node.js](http://nodejs.org), [Express](expressjs.com) and [MongoDB](https://www.mongodb.com/).

## Application Logics

It can be a discussion forum, blog system, e-commerce site, online gaming site, social network, or any other web application by your choice.

"Cooking e-Web Application" consist of the 2 main parts:

- **public part** (accessible without authentication)
- **private part** (available for registered users)

### Public Part

The **public part** is **visible without authentication**. This public part includes the following pages:

1) the application start page: contains public menu options and a search option;
2) user login page: login possible through user's site account or through Facebook account;
3) user registration page;
4) categories page: buttons with links for each category; when clicked, the the recipes of this category are displayed;
5) page with articles on cooking and alimentary topics;
6) recipes by category chosen from the category page. 
 
### Private Part (Registered users area)

**Registered users** have personal area in the web application accessible after **successful login**.
This area holds the following pages:

1) the user's profiles management functionality;
2) pages for database CRUD operations on cooking recipes and categories;
3) pages for database CRUD operations on popular cooking articles;
4) "My author's recipes" page;  
5) "My favorite recipes" page; 
6) recipes by category chosen from the category page; 
7) application statistics page

## Technical Requirements

In "Cooking e-Web Application" the following technologies, frameworks and development techniques are used:

### Application Back-end (Server)

- At least **5 different public dynamic web pages**
  - Using [Pug](https://pugjs.org/)
- At least **3 different private (authenticated) dynamic web pages**
  - Using [Pug](https://pugjs.org/)
- At least **5 different public RESTful routes** for AJAX
- At least **1 private (authenticated) route** for AJAX
- Use **Express** for the server
  - Use an **MV-*** pattern
- Use **MongoDB**
  - As data storage
  - Optionally, you may use **Mongoose** or any other ODM framework
- Create a data/service layer for accessing the database
- Use [Passport](http://passportjs.org/) - for managing **users**
  - Your registered users should have at least one of the two roles: **user**

### Application front-end (client)

- Use any framework of your choice for the front-end
  - Optional, not required
  - KendoUI, AngularJS, Angular 2, Knockout, Bootstrap, etc...
- implement responsive design
  - It may be based on **Bootstrap**, **Materialize** or any other UI framework
- Use at least **one AJAX form and/or WebSockets communication**
- Write at least **10 different unit tests** for your controllers and data logic
- Apply **error handling** and **data validation** to avoid crashes when invalid data is entered
- Prevent yourself from **security** holes (XSS, XSRF, Parameter Tampering, etc.)
  - Handle correctly the **special HTML characters** and tags like `<script>`, `<br />`, etc.

##  General Requirements

- Use Git
  - Github, Gitlab, Bitbucket, or other
- Brief **documentation** of the project and the project architecture
  - As `README.md` file at the root of the github repository

### Optional Requirements

- Nice looking UI supporting of all modern and old Web browsers
- Good usability (easy to use UI)
- Record a short video showcasing your application
  - ~1-2 minutes, just show the interesting features
  - Do not record register/login functionality, this is not interesting...

### Deliverables

- Upload your application in the cloud
  - MS Azure, HerokuCloud, Amazon, all are fine
- Register your application at [Our Showcase System](http://best.telerikacademy.com)
  - Link to the live application
  - Link to the video
  - Link to the github repository

### Public Project Defense

Each team will have to make a **public defense** of its work in front of a trainer (for about 30 minutes), in which each of the team members will answer to the trainer's questions individually.

The public defense includes:

- Live **demonstration** of the developed web application (prepare sample data).
- Explain application structure and its back-end and front-end **source code**
- Show the **commit logs** in the source control repository to prove a contribution from all team members.
- May include a simple task for each team member
  - The task must be implemented immediately

### Give Feedback about Your Teammates

You will be invited to **provide feedback** about all your teammates, their attitude to this project, their technical skills, their team working skills, their contribution to the project, etc.
The feedback is important part of the project evaluation so **take it seriously** and be honest.

Twitter Bootstrap is used for the responsive design.
e-Libray have 2 type of users - administrator and users.
[Administrator](http://french-connection.apphb.com/#/admin) recive latest messages from contacts form. 

He can [add](http://french-connection.apphb.com/#/admin/addbook),[edit](http://french-connection.apphb.com/#/admin/editbook)  and [remove](http://french-connection.apphb.com/#/admin/removebook) books by ID, title or ISBN.

From [Home page](http://french-connection.apphb.com/#/home), the user can explore library or top books (most viewed books from application.)

When clicked on the [book](http://french-connection.apphb.com/#/library/detailed/G0MMeBZtxI), the user can view all book details from our Parse Backend Services, to dowload the book for Kindle from Amazon and shared via Twitter.

In the [Category](http://french-connection.apphb.com/#/categories) page, all existing categories are listed.
The [Search](http://french-connection.apphb.com/#/library/search) is using Underscore.js and jQuery for filtering the books by title, auther, category, description.

Users can [signup](http://french-connection.apphb.com/#/account/signup) and [login](http://french-connection.apphb.com/#/account/login) if all their data is valid. 


## References
[SystemJS](https://github.com/systemjs/systemjs)
[jQuery](https://jquery.com/)
[Handlebars](http://handlebarsjs.com/)
[Twitter Bootstrap](http://getbootstrap.com/)
[Sammy] (http://sammyjs.org/) as route loader 
[Undescore](http://underscorejs.org/)
[Babel](https://babeljs.io/)

-------------------------------------------------------------------------------------

