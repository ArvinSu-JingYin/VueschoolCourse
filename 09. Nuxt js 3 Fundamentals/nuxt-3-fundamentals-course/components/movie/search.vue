<script lang="js" setup>
const movies = ref([]);
const query = ref("");

async function search() {
  const { Search } = await $fetch(
    `http://www.omdbapi.com/?s=${query.value}&apikey=bbf73337`
  )
    movies.value = Search;
    //console.log(JSON.stringify(movies.value));
}
</script>

<template>
  <div>
    <form @submit.prevent="search">
      <input type="text" v-model="query" />
      <button type="submit">Search</button>
    </form>
    <ul style="display: flex; flex-wrap: wrap; gap: 1rem; list-style: none">
      <li v-for="movie in movies" :key="movie.imdbID">
        <NuxtLink :to="{ name: 'movies-id', params: { id: movie.imdbID } }">
          <img :src="movie.Poster" alt="movie.title" />
        </NuxtLink>
      </li>
    </ul>
  </div>
</template>

<style scoped></style>