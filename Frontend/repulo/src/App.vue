<template>
 <nav-bar /> 
<RouterView ></RouterView> 
</template>


<script>
import {RouterView} from "vue-router";
import NavBar from './components/NavBar.vue'
export default {
    components: {
    NavBar,
    RouterView
}
}
</script>