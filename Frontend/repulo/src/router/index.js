import { createRouter, createWebHistory } from 'vue-router'
import Jaratok from '../views/Jaratok.vue'
import Foglalas from '../views/Foglalas.vue'
import Repulo from '../views/Repulo.vue'
import Index from '../views/Index.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path:'/Jaratok',
      name:'Jaratok',
      component:Jaratok
    },
    {
      path:'/Foglalas',
      name:'Foglalas',
      component:Foglalas
    },
    {
      path:'/Repulo',
      name:'Repulo',
      component:Repulo
    },
    {
      path:'/',
      name:'Index',
      component:Index
    }
  ]
})

export default router
