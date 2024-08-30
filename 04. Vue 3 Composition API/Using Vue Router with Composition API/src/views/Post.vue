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

//Type 1
// import usePost from '../composables/usePost.js'
// import useUser from '../composables/useUser.js'
// const {post, fetchOne} = usePost()
// fetchOne(route.params.id)

// const {user, fetchOne: fetchUser} = useUser()
// fetchUser(1)


//Type 2
//Post
const {item: post, fetchOne: fetchPost} = useResource('posts')
fetchPost(route.params.id)

// User
const {item: user, fetchOne: fetchUser} = useResource('users');
watch(
  ()=>({...post.value}),
  () => fetchUser(post.value.userId)
)



</script>
