<template>
  <div class="flex flex-wrap flex-grow">
    <PostCard v-for="post in posts" :key="post.id" :post="post" />
  </div>
</template>
<script setup>
//import useResource from '../composables/useResource.js'
import PostCard from "../components/PostCard.vue";
// const {items: posts, fetchAll} = useResource('posts')

import usePost from '../composables/usePost.js'
const {posts, fetchAll} = usePost()
fetchAll()
</script>
