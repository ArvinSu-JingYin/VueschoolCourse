/*
createWebHashHistory uses the URL hash for routing (e.g., http://example.com/#/home)
createWebHistory uses the HTML5 history mode for routing (e.g., http://example.com/home)
*/
import { createRouter, createWebHistory } from 'vue-router'
import Home from '@/views/Home.vue'

//type 1
/*
import Brazil from '@/views/Brazil.vue'
import Hawaii from '@/views/Hawaii.vue'
import Jamaica from '@/views/Jamaica.vue'
import Panama from '@/views/Panama.vue'

const routes = [
  { path: '/', component: Home },
  { path: '/about', component: About },
  { path: '/brazil', name: 'Brazil', component: Brazil },
  { path: '/hawaii', name: 'Hawaii', component: Hawaii },
  { path: '/jamaica', name: 'Jamaica', component: Jamaica },
  { path: '/panama', name: 'Panama', component: Panama },
]
*/

//type 2 : lazy loading
const routes = [
  { path: '/', component: Home },
  { path: '/brazil', name: 'Brazil', component: () => import('@/views/Brazil.vue') },
  { path: '/hawaii', name: 'Hawaii', component: () => import('@/views/Hawaii.vue') },
  { path: '/jamaica', name: 'Jamaica', component: () => import('@/views/Jamaica.vue') },
  { path: '/panama', name: 'Panama', component: () => import('@/views/Panama.vue') },

  //type 3 : dynamic import
  {path: '/destination/:id', name: 'Destination.Show', component: () => import('@/views/DestinationShow.vue')}
]

//type 4 : dynamic import with named routes


const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router
