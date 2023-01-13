<template>
<div id="mainNavigation">
    <nav role="navigation">
      <div class="py-3 text-center border-bottom">
       <img src="src/assert/img/repulo.png" alt="" class="invert">
      </div>
    </nav>
    <div class="navbar-expand-md">
      <div class="navbar-dark text-center my-2">
        <button class="navbar-toggler w-75" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span> <span class="align-middle">Menu</span>
        </button>
      </div>
      <div class="text-center mt-3 collapse navbar-collapse" id="navbarNavDropdown">
        <ul class="navbar-nav mx-auto ">
          <li class="nav-item">
            <a class="nav-link" href="index.html">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="repulo.html">Repülők</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="jaratok.html">Járatok</a>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              Profil
            </a>
            <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
              <li><a class="dropdown-item" href="adatok.html">Foglalás</a></li>
              <li><button onclick="bezar()" class="dropdown-item">Bezárás</button></li>
            </ul>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>
