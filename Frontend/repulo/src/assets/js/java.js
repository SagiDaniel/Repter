'use strict';

function check(){
const check = document.getElementById("vasar").checked;
if(check==true)
{
    document.getElementById("vasar").disabled = false;
}
else
{
    document.getElementById("vasar").disabled = true;
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
const hazais=0;
function odavissza(){
const odavissza = document.getElementById("odavissza").checked;

if(odavissza==false){
  document.getElementById("datumvissza").disabled=false;
  hazais=0;
}
else{
  document.getElementById("datumvissza").disabled=true;
  hazais=1;
}



}

/*Reülő hozzáadás */
function varosuj(){
  
const varosnev = document.getElementById("varos").value;
const varosletszam = documentm.getElementById("letszam").value;
if(varosnev!="")
{


if(varosletszam!="")
{

}

}} 
function foglalas(){
 //áfa 27%
 //kerozin távolság*0,10+tavolsag
 //celallomas populacio 0m-2m=>5% 2m-10m=>7,5%   10m+=10% 
 //csoportos kedvezmeny 10fo 10% vegosszegbol
 //16ev alatt vegosszeg 80%
 /* 
  const felnott = document.getElementById("felnott").value;
  const kamasz = document.getElementById("kamasz").value;
  const gyerek = document.getElementById("gyerek").value;
  const csecsemo = document.getElementById("csecsemo").value;
  const uticel = document.getElementById().value;
  const uticellakossag=document.getElementById().value;
  const uticelszorzo=0;
  const csoport = kamasz+felnott+gyerek+csecsemo;
  if(uticellakossag>10000000)
  {
    uticelszorzo=0,10;
  }
  else if(uticellakossag>2000000)
  {
    uticelszorzo=0,05;
  }
  else  
  {
    uticelszorzo=0,02;
  }
  const vegosszeg=0;
  const kerozinar=0;
  const arseged=0;
  kerozinar = (uticel*0,27+uticel)*uticelszorzo;//ÁFA+lakossagszorzo

  if(felnott!=0)
  {
    vegosszeg+=kerozinar*felnott;
  }
  if(kamasz!=0)
  {
    arseged=kerozinar*kamasz;
    vegosszeg+=arseged*0,80;
  }
  if(gyerek!=0)
  {
    arseged=kerozinar*gyerek;
    vegosszeg+=arseged*0,80;
  }
  if(csecsemo!=0)
  {
    arseged=kerozinar*csecsemo;
    vegosszeg+=arseged*0,80;
  }
  if(csoport>9)
  {
    vegosszeg=vegosszeg*0,80;
  }
  if(hazais=1)
  {
    vegosszeg=vegosszeg*2;
  }
  */
}