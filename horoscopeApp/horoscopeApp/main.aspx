<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="horoscopeApp.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset=""UTF-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" 
rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"
 crossorigin="anonymous"/>
<link rel="stylesheet" href="StyleSheet1.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navbar -->
<nav class="navbar navbar-expand-lg bg-dark navbar-dark py-3">
    <div class="container">
        <a href="https://www.justintruong.studio/index.html" class="navbar-brand">Web <span class="text-primary">Portfolio</span></a>
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
                    This application returns a person's horoscope based on their sign and consists of two components. The first is a REST API made with Python, Flask-Restx, and BeautifulSoup that scrapes the www.horoscope.com website 
                    for horoscope data and returns it in JSON format. The second component is a web application that gets it's data from the REST API that is written in C# using the ASP.Net 
                    framework, HTML/CSS, and the Bootstrap 5 framework. 
                </p>
                <a href="https://horoscopeapiv1.azurewebsites.net/" class="btn btn-warning btn-lg" target="_blank" 
                rel="noopener noreferrer">
                    View the api
                </a>
                <a href="https://github.com/Truong-Justin/horoscopeApi" class="btn btn-secondary btn-lg my-1" target="_blank" 
                rel="noopener noreferrer">
                    Click here for API Code
                </a>
                
                <a href="https://github.com/Truong-Justin/horoscopeApp" class="btn btn-light btn-lg my-1" target="_blank" 
                rel="noopener noreferrer">
                    Click here for App Code
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
                        <img class="w-25 mx-auto d-none d-sm-block my-2" src="images/moon.png"/>
                        <img class="w-50 mx-auto d-sm-none  my-2" src="images/moon.png"/>
                        
                        
                    
                        <div id="round_div" class="bg-dark mb-3">
                        <h1 class="text-center text-light mt-5"><span class="text-warning">Horoscope</span> Application</h1>
                            <asp:DropDownList ID="DropDownList1" class="btn btn-sm btn-warning my-5 text-center mx-auto d-block" 
                                              runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" CausesValidation="True">
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
                        <li class="text-light">Back-end scrapes data from  www.horoscope.com and returns the horoscope data</li>
                        <li class="text-light">Front-end displays horoscope based on zodiac sign/animal and chosen timeframe</li>
                        <li class="text-light">Horoscope data is viewable by user without the need for a database</li>
                        <li class="text-light">API & Front-Facing App is hosted on Microsoft Azure</li>

                    </ul>

                <h2 id="project_descriptions"><span class=text-warning>Motivations</span> For Project</h2>
                <p class="text-light">When I started this project, I was also introduced to HTML/CSS and the Bootstrap 5 framework and wanted to practice my skills with front-end technologies. 
                    After getting some experience consuming APIs with past projects, I wanted to try and make my own API and make a front-end application that consumed from it. 
                    
                </p>
                    
                
                <h2 id="project_descriptions"><span class=text-warning>Why</span> I Built This Project</h2>
                <p class="text-light">Webscraping and APIs have been two domains that I've been curious about and wanted to dive into for a project. Python's BeautifulSoup and Flask libraries made the process easy to understand
                    for the API portion of this project. To process the API endpoints, I used C# and the ASP.Net framework to build the user-facing portion of the project. 
                </p>

                <h2 id="project_descriptions"><span class=text-warning>What</span> I Learned</h2>
                <p class="text-light">While working on this project I learned: how to use the BeautifulSoup library to scrape data from the horoscope website, how to use Flask-Restx to 
                    return the horoscope data in a JSON format, and how to access the data via the API endpoints. I was also introduced to using environment variables within a .env file that held
                    a unique password for the API.  
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
