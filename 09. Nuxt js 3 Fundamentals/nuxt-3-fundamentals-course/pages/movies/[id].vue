<script setup>
import { ref, onMounted } from "vue";

const route = useRoute();
// const res = ref(null); // 定義響應式變數 res

//type 1
/* 
useAsyncData is a built-in function in Nuxt 3, used to handle asynchronous data requests.
Its features include:
- Automatically handles requests and responses
- Supports caching and retry mechanisms
- Can be integrated with Nuxt's routing system
- Provides a simple API to handle asynchronous data
*/
const { data } = useAsyncData(() => {
  return $fetch(`http://www.omdbapi.com/?i=${route.params.id}&apikey=bbf73337`);
});

//type AI
// onMounted(async () => {
//   res.value = await $fetch(
//     `http://www.omdbapi.com/?i=${route.params.id}&apikey=bbf73337`
//   );
// });
</script>

<template>
  <div>
    <div v-if="data">
      <pre>{{ JSON.stringify(data, null, 2) }}</pre>
    </div>
    <div v-else>
      <h1>Loading...</h1>
    </div>
  </div>
</template>