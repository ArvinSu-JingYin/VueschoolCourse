<template>
  <!-- type 1 : static link -->
  <!-- <div id="nav">
    <router-link to="/">Home</router-link>
    <router-link to="/brazil">Brazil</router-link>
    <router-link to="/hawaii">Hawaii</router-link>
    <router-link to="/jamaica">Jamaica</router-link>
    <router-link to="/panama">Panama</router-link>
  </div> -->

  <!-- type 2 : dynamic link -->
  <div id="nav">
    <router-link id="logo" to="/"> Vue School Travel App </router-link>
    <router-link
      v-for="destination in destinations"
      :key="destination.id"
      :to="{
        name: 'Destination.Show',
        params: {
          id: destination.id,
          slug: destination.name, // Using 'name' as the slug for simplicity
        },
      }"
      >{{ destination.name }}</router-link
    >
  </div>
</template>

<script>
export default {
  data() {
    return {
      destinations: [],
    };
  },
  async created() {
    try {
      const response = await fetch(`https://localhost:44343/GetTravelDataNav`);
      this.destinations = await response.json();
      console.log(this.destinations);
    } catch (error) {
      console.error("Error fetching destinations:", error);
    }
  },
};
</script>