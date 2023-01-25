<template>
<div id="mainNavigation">
    <nav role="navigation">
      <div class="py-3 text-center border-bottom">
       <img src="../assets/img/repulo.png" alt="" class="invert">
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
            <router-link class="nav-link" to="/">Index</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/Repulo">Repülők</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/Jaratok">Járatok</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/Foglalas">Foglalás</router-link>
          </li>
        </ul>
      </div>
    </div>
  </div>


</template>
<script>
import "../assets/js/java.js"
import {RouterLink} from "vue-router";
export default {
    components: {
RouterLink

}
}
</script>
