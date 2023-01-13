'use strict';

function check(){
const check = document.getElementById("vasar").checked;
if(check==false)
{
    document.getElementById("vasar").disabled = true;
}
else
{
    document.getElementById("vasar").disabled = false;
}
}
function vasarlas()
{
    const vezeteknev =document.getElementById("vezetek").value;
    const keresztenv = document.getElementById("kereszt").value;
    const email = document.getElementById("email").value;
    if(email!=""&& vezeteknev!="" && keresztenv!="")
    {
    alert("Sikeres foglalás");
    }
    else{
        alert("Nincs kitöltve minden adat!");
    }
}
function kukac(){
    document.getElementById("email").value+="@";
  }
function torles()
  {
  alert("A kosár tartalma mostantól üres");
  for(const item of kosar){
      kosar.pop();
  }
}

function bezar(){
  var win = window.open("", "_self");
  win.close();
}

var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName("kepek");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none"; 
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1} 
  slides[slideIndex-1].style.display = "block"; 
  setTimeout(showSlides, 10000); 
}


function torles(){
    var inputs = document.getElementsByTagName("input");
    for (var i = 0; i < inputs.length; i++) {
    inputs[i].value = "";
  }
}
function utasokvalasztas(){
  const check = document.getElementById("utasok");
if(check.value  =="egyeb")
{
    document.getElementById("utasokegyeb").disabled = false;
}
else
{
    document.getElementById("utasokegyeb").disabled = false;
}
}