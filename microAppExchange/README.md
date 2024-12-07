# microAppPattern
 the micoAppPattern PoC 22.1

1. A bit of background on the microAppPattern
    https://www.linkedin.com/pulse/microapp-pattern-10-suresh-banda/
    https://medium.com/@techist007/the-microapp-pattern-1-0-e6cb1296105e
    https://twitter.com/hashtag/MicroAppPattern
    https://github.com/techist007/microAppPattern

 2. The Hachiko microapp
    2.1. The microDatabase
        2.1.1. Written in JSON.
        2.1.2. A built-in-hachikoMicroServer microDatabase.
    2.2. The hachikoMicroServer
        2.2.1. Written in NodeJs.
        2.2.2. Go to the root folder and enter "nodemon".
        2.2.3. Open a browser and enter "http://localhost:20000/api/hachiko" and you should be getting the json response with Hachiko details.
    2.3. The hachikoMicroUI
        2.3.1. Written in jQuery.
        2.3.2. Go to the root folder and enter "http-server -p 11000 --cors".
        2.3.3. Open a browser and enter "http://localhost:11000/hachiko.html" and you should now be looking at the Hachiko microApp came up.  

 3. The Pizza microapp
    3.1. The pizzaMicroDatabase
        3.1.1. Go to the root folder and enter "nodemon microDatabase.js".
        3.1.2. Open the browser and enter "http://localhost:30000/api/pizzas" and you should now be getting the json response with the details of pizzas.
    3.2. The pizzaMicroServer
        3.2.1. Written in .net core 6 as a minimal api.
        3.2.2. Go to the root folder and enter "dotnet dev-certs https --trust".  In mac, you may be asked to enter the login keychain password.
        3.2.3. Go to the root folder and enter "dotnet run".
        3.2.4. Open the browser and enter "https://localhost:7202/menuForTheDayAsync" and you should now be getting the json response with the details of pizzas.  The port may be different on your machine.  If it is, go to the menuOfTheDay component in the pizza-micro-ui and replace it with the updated url and save the file.  React should be recompiling automatically.
    3.3. The pizza-micro-ui
        3.3.1. Written in ReactJS
        3.3.2. Go to the root folder and enter "npm start".       
        3.3.3. Open a browser and enter "http://localhost:3000" and you should now be looking at the Pizza microApp came up.
 
 4. The Orders microapp
    4.1. The microDatabase
        4.1.1. Written in JSON.
        4.1.2. A built-in-hachikoMicroServer microDatabase.
    4.2. The OrdersMicroServer
        4.2.1. Written in Flask
        4.2.2. Go to the root folder and enter "pip install -U flask-cors".
        4.2.2. Go to the root folder and enter "flask --app orders.py run".
        4.2.3. Open the browser and enter "http://localhost:5000/orders" and you should now be getting the json response    with the details of the orders.
    4.3. The OrdersMicroUI
        4.3.1. Written in VueJS.
        4.3.2. Go to the root folder and enter "npm run dev".
        4.3.3. Open a browser and enter "http://localhost:5173" and you should now be looking at the Orders microApp came up.

5. The control center
    5.1. controlCenterMicroUI
        5.1.1. Go to the root folder and enter "http-server -p 10000 --cors".
        5.1.2. Open the browser and enter "http://localhost:10000/dashboard.html" and you should now be looking at the control center hosting the 3 micro apps written in different technologies in one page.
