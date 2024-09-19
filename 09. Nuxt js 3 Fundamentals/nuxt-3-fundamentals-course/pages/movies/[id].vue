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
/* type 1 : example
const { data } = useAsyncData(
  `/movies/${route.params.id}`,
  () => {
    return $fetch(
      `http://www.omdbapi.com/?i=${route.params.id}&apikey=bbf73337`
    );
  },
  //use pick to pick the data
  {
    pick: ["Plot", "Title"],
  }

  //use transform to modify the data
  // {
  //   transform(data) {
  //     return {
  //       Plot: data.Plot,
  //     };
  //   },
  // }
);
*/

//type AI
// onMounted(async () => {
//   res.value = await $fetch(
//     `http://www.omdbapi.com/?i=${route.params.id}&apikey=bbf73337`
//   );
// });

//type 2
const { data, error } = await useFetch(
  `http://www.omdbapi.com/?i=${route.params.id}&apikey=bbf73337`,
  {
    pick: ["Plot", "Title", "Poster", "Error"],
    key: `/movies/${route.params.id}`,
  }
);

if (error.value) {
  console.log(error.value);
}

if (data.value.Error === "Incorrect IMDb ID.") {
  showError({
    statusCode: 404,
    statusMessage: "Page not found",
  });
}

useHead({
  title: data.value.Title,
  meta: [
    { name: "description", content: data.value.Plot },
    { property: "og:image", content: data.value.Poster },
    { property: "og:description", content: data.value.Plot },
    { name: "twitter:card", content: "summary_large_image" },
  ],
});
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