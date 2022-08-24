﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="horoscopeApp.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset=""UTF-8">
<meta http-equiv=""X-UA-Compatible" content="IE=edge, chrome=1">
<meta name="viewport" content="width=devide-width, initial-scale=1.0">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" 
rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"
 crossorigin="anonymous">
<link rel="stylesheet" href="StyleSheet1.css">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navbar -->
<nav class="navbar navbar-expand-lg bg-dark navbar-dark py-3">
    <div class="container">
        <a href="index.html" class="navbar-brand">Web <span class="text-primary">Portfolio</span></a>
        <button class="navbar-toggler" 
        type="button" 
        data-bs-toggle="collapse" 
        data-bs-target="#navmenu">
        <span class="navbar-toggler-icon"></span>
    </button>

        <div class="collapse navbar-collapse" id="navmenu">
            <ul class="navbar-nav ms-auto">
                <li class="nav-item">
                    <a href="https://www.justintruong.studio/index.html" class="nav-link">About Me</a>
                </li>
                <li class="nav-item">
                    <a href="https://www.justintruong.studio/projects.html" class="nav-link">Projects</a>
                </li>
                <li class="nav-item">
                    <a href="https://www.justintruong.studio/cv.html" class="nav-link">CV</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!--Showcase-->
<section class="bg-dark text-light p-4 text-center text-sm-start">
    <div class="container">
        <div class="d-sm-flex align-items-center justify-content-between">
            <div class="py-5">
                <h1><span class="text-warning">RESTful</span> Horoscope API</h1>
                <p class="lead my-4">
                    Developed using Python, BeautifulSoup, and the Flask-Restx framework. This application scrapes horoscope data from www.horoscope.com and returns
                    it in a JSON format. 
                </p>
                <a href="https://horoscopeapi.justintruong.studio" class="btn btn-warning btn-lg" target="_blank" 
                rel="noopener noreferrer">
                    View the api
                </a>
                <a href="https://github.com/Truong-Justin/horoscopeApi" class="btn btn-warning btn-lg my-4" target="_blank" 
                rel="noopener noreferrer">
                    Click here for code
                </a>
                

                
            </div>
            <img class="img-fluid w-25 d-none d-sm-block" 
            src="images/horoscope.svg" 
            alt="programming picture" 
            >
            
        </div>
    </div>
    </section>
       

<!--Horoscope App GUI -->
    <section class="p-5 bg">
        <div class="container">
            <div class="d-sm-flex row align-items-center justify-content-between">
                
                    <div class="row" id="border">
                        <img class="w-25 mx-auto d-none d-sm-block my-2" src="images/moon.png">
                        <img class="w-50 mx-auto d-sm-none  my-2" src="images/moon.png">
                        
                        
                    
                        <div id="round_div" class="bg-dark mb-3">
                        <h1 class="text-center text-light mt-5"><span class="text-warning">Horoscope</span> Application</h1>
                            <asp:DropDownList ID="DropDownList1" class="btn btn-sm btn-warning my-5 text-center mx-auto d-block" 
                                              runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>Select zodiac sign</asp:ListItem>
                                <asp:ListItem>Aries</asp:ListItem>
                                <asp:ListItem>Taurus</asp:ListItem>
                                <asp:ListItem>Gemini</asp:ListItem>
                                <asp:ListItem>Cancer</asp:ListItem>
                                <asp:ListItem>Leo</asp:ListItem>
                                <asp:ListItem>Virgo</asp:ListItem>
                                <asp:ListItem>Libra</asp:ListItem>
                                <asp:ListItem>Scorpio</asp:ListItem>
                                <asp:ListItem>Sagittarius</asp:ListItem>
                                <asp:ListItem>Capricorn</asp:ListItem>
                                <asp:ListItem>Aquarius</asp:ListItem>
                                <asp:ListItem>Pisces</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" CellPadding="4" ForeColor="White" AutoPostBack="True">
                                <asp:ListItem>Yesterday</asp:ListItem>
                                <asp:ListItem Selected="True">Today</asp:ListItem>
                                <asp:ListItem>Tomorrow</asp:ListItem>
                                <asp:ListItem>Weekly</asp:ListItem>
                                <asp:ListItem>Monthly</asp:ListItem>
                            </asp:RadioButtonList>
                           
                            
                        <p runat="server" id="paragraph" class="text-light mt-3">(Select your zodiac sign from the dropdown menu, and select a timeframe to view your horoscope)</p>
                        </div>
                    
                    </div>
            </div>
        </div>

    </section>

    <!--Project information-->
    <section class="p-5 bg-dark text-light">
        
        <div class="container">
            <div class="d-sm-flex row align-items-center justify-content-between">
                
                <div class="col-md">
                    <h2 style="text-decoration-line:underline; text-decoration-color:slategray"><span class=text-warning>Features</span> and Highlights</h2>
                    <ul>
                        <li class="text-light">Back-end interfaces with Horoscope.com website and returns the horoscope data</li>
                        <li class="text-light">Front-end displays horoscope based on zodiac sign/animal and chosen timeframe</li>
                        <li class="text-light">Horoscope data is viewable by user without the need for a database</li>
                        <li class="text-light">API is Hosted on Amazon's Elastic Beanstalk, Front-Facing App is hosted on Microsoft Azure</li>

                    </ul>
                    
                
                <h2 id="project_descriptions"><span class=text-warning>Why</span> I Built This Project</h2>
                <p class="text-light">Webscraping and APIs have been two domains that I've been curious about and wanted to dive into for a project. Python's BeautifulSoup and Flask libraries made the process a breeze
                    for the API portion of this project. To process the API endpoints, I used C# and the ASP.Net framework to build the user-facing portion of the project. 
                </p>

                <h2 id="project_descriptions"><span class=text-warning>What</span> I Learned</h2>
                <p class="text-light">While working on this project I learned: how to use the BeautifulSoup library to scrape data from the horoscope website, how to use Flask-Restx to 
                    return the horoscope data in a JSON format, and how to access the data via the API endpoint. 
                </p>
                </div>
            </div>
        </div>
    </section>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" 
        crossorigin="anonymous"></script>
</body>
</html>
