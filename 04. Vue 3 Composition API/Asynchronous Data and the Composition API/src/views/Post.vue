<template>
  <div v-if="post && user">
    <h1 class="text-3xl">{{ post.title }}</h1>
    <div class="text-gray-500 mb-10">by {{ user.name }}</div>
    <div>{{ post.body }}</div>
  </div>
</template>
<script setup>
import {useRoute} from 'vue-router'
import {watch} from 'vue'
//import useResource from '../composables/useResource.js'
const route = useRoute()

//Post
const {item: post, fetchOne: fetchPost} = useResource('posts')
fetchPost(route.params.id)

// User
const {item: user, fetchOne: fetchUser} = useResource('users');

//type1
// fetchPost(route.params.id).then(()=>{
//   fetchUser(post.value.userId)
// })

//type2
// (async ()=>{
//   await fetchPost(route.params.id)
//   fetchUser(post.value.userId)
// })()

//type3
watch(
  ()=>({...post.value}),
  () => fetchUser(post.value.userId)
)

</script>
