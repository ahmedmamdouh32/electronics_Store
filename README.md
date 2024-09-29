<h1>Electronics Store</h1>
<h6>In this repo you will find a system that reads data of components in Electronics Store that is stored in <b>SQL Server</b>.</h6>

<p>The application consists of three layers</p>
<ul>
  <li> <b>UI</b> (User Interface Layer) </li>
  <li> <b>BLL</b> (Business Logic Layer) </li>
  <li> <b>DAL</b> (Data Access Layer) </li>
</ul>

<p>Lets talk about each layer and its role.</p>
<br>

<h3>Data Access Layer (DAL)</h3>
<p>It is the layer that access the server, it
    contains a code that takes from you the query or stored procedure and <br> runs 
    it on the server and also retrun the data released from the server to your application.
</p>

<br>

<h3>Business Logic Layer (BLL)</h3>
<p>this layer contains the vusiness logic of the application, it does not contain any ADO methods,
    <br>this layer works on calling methods from DAL and passing them the name of stored procedure
    <br> and then receive the return data from those methods.
    <br>All logic on data is done in this layer before displaying it to the end user.
</p>

<br>

<h3>User Intrerface Layer (UI)</h3>
<p>this layer simply contains the interface of th eprogram(Button,List,TextBox) and so on.
    <br>the role of this layer is that when user pressed a button the methods inside this layer
    <br> are programmed to call a method from BLL and passes it the name of stored procedure
    <br>that will be executed by the server.
</p>

<br>

<h3>Project execution steps :</h3>
<p>1- first thing the user presses on a button.
    <br>2- the key is programmed to run a method written in the BLL layer, this method takes the name of procedure(1) to be executed by the server.
    <br>3- then the called method start calling another method in the DAL layer to make a connection between the application and the server and also to handle the procedure and execute it on the level of the server.
    <br>4- The server execute the procedure and return its data back to DAL
    <br>5- DAL passes the data to BLL Layer to make some processes on it
    <br>6- then at the end the data become ready to be displayed on th screen through the UI layer 
</p>

