# FruitStack
<div>
  <img src="https://user-images.githubusercontent.com/90128195/210262239-c4a91025-3967-4668-bc00-31d4637c17e3.png" alt="">
  <img src="https://user-images.githubusercontent.com/90128195/210262311-d5fbdb8f-efa8-4379-b021-c387e171ae80.png" alt="">
  <img src="https://user-images.githubusercontent.com/90128195/210262292-1dcb627d-bc25-4a84-9647-bb8c19be99f8.png" alt="">
  <img src="https://user-images.githubusercontent.com/90128195/210262337-81b2544c-1d7b-4e01-a415-c8e0436f78a4.png" alt="">
  <img src="https://user-images.githubusercontent.com/90128195/210270458-9d74d483-cf47-4271-a4ef-e3955078e984.png" alt="">
  <img src="https://user-images.githubusercontent.com/90128195/210270554-7d517323-9de1-4c39-ba95-5f37bfd278da.png" alt="">
</div>

<h2>
  Hello There ✌️
</h2>

  <h3>What is FruitStack?</h3>
    This is a small pet project about fruits. Made for educational purposes only.
    To study the work of a client-server web application and understand how to work with Api`s.<br>
    Implemented in the project - receiving and processing data with api, in memory cache, pagination, visual components(modals, spinner, custom scrollbar) etc.
    <img src="https://github.com/ChaklunIvan/FruitStack/blob/master/ui/src/assets/gifs/homepage.gif?raw=true" alt="">
    <img src="https://github.com/ChaklunIvan/FruitStack/blob/master/ui/src/assets/gifs/home-to-fruits-spinner-pagination-modal.gif?raw=true" alt="">
    <img src="https://github.com/ChaklunIvan/FruitStack/blob/master/ui/src/assets/gifs/home-to-fruits-spinner-toast.gif?raw=true" alt="">
    <img src="https://github.com/ChaklunIvan/FruitStack/blob/master/ui/src/assets/gifs/home-to-about.gif?raw=true" alt="">
    
<h2>
  Technologies 🛠:
</h2>
<h3 style="margin-top="8px"">
  Server - .Net<br>
  Api`s - Fruityvice (https://www.fruityvice.com), Unsplash (https://unsplash.com)<br>
  Client - Angular, Bootstrap<br>
</h3>
<div>
  <img width="24px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/angular_logo_icon_169595.png" alt="">
  <img width="24px" src="https://uxwing.com/wp-content/themes/uxwing/download/brands-and-social-media/microsoft-dot-net-icon.png" alt="">
  <img width="24px" src="https://cdn-icons-png.flaticon.com/512/5968/5968672.png" alt="">
</div>

<h2>
  Server and Api 🔌
</h2>

<h4>
  The server made on .NET has an n-layer monolithic architecture.<br>
  Server requesting to two different api`s (fruityvice, unsplash) and get fruits and images to fruits.<br>
  Then with automapper response dto models, from api`s, converting to main dto model 'FruitResponse'.<br>
  Which goes to the client.<br>
</h4>
<h4> Fruityvice - api with a small database storing fruits</h4>
<h4> Unsplash - api service with a large database of copyright photos</h4>
<h3>Controller:</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210269056-07870371-f4c7-4868-bce5-5c200061169a.png" alt="">

<h3>FruitService:</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210269228-22d16b78-5ce0-434a-9f25-6fb266280dc1.png" alt="">

<h3>ImageService:</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210269292-13b25f76-3d09-4b9e-bde4-301dc58f2444.png" alt="">

<h3>Mapper:</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210269362-efb434eb-a38e-45e5-a0d2-34b361812f26.png" alt="">
<img width="" src="https://user-images.githubusercontent.com/90128195/210269397-40e1e9d5-a99f-4857-85b2-34e5bbcdfe74.png" alt="">

<h2>
  Client 🖥️
</h2>
<h4>
  The client is made using angular and bootstrap styles.<br>
  Consists of several components and one service for getting fruits from the server
</h4>
<h3>Components</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210270130-fcf85ec8-cc39-41e7-9d99-12fb7f2bb309.png" alt="">

<h3>FruitService:</h3>
<img width="" src="https://user-images.githubusercontent.com/90128195/210270173-b0fa73dd-5de1-4760-acb1-7d5b1f23ec68.png" alt="">

