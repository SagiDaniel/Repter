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


/*
function torles(){
    var inputs = document.getElementsByTagName("input");
    for (var i = 0; i < inputs.length; i++) {
    inputs[i].value = "";
  }
}*/
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


/*

// JavaScript fájl

// Lekérdezési URL megadása
const url = 'https://example.com/data.json';

// fetch() függvény használata a lekérdezéshez
fetch(url)
  .then(response => response.json()) // adatok json formátumba való átalakítása
  .then(data => {
    // Adatok feldolgozása és megjelenítése az HTML oldalon
    const table = document.querySelector('table');
    data.forEach(item => {
      const row = document.createElement('tr');
      row.innerHTML = `<td>${item.name}</td><td>${item.age}</td>`;
      table.appendChild(row);
    });
  })
  .catch(error => {
    // Hiba esetén hibaüzenet megjelenítése 
    console.log(error);
    const message = document.querySelector('.message');
    message.innerText = 'Hiba történt az adatok lekérdezése közben';
  });

*/
/*


  const audio = document.getElementById('my-audio');
audio.play();

audio.pause();
window.onbeforeunload = () => audio.pause();
*/
function odavissza(){
const odavissza = document.getElementById("odavissza").check;
if(odavissza==false){
  document.getElementById("datumvissza").disabled=false;
}
else{
  document.getElementById("datumvissza").disabled=true;
}
}