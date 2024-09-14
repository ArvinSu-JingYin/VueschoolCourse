<template>
  <section v-if="destination" class="destination">
    <h1>{{ destination.name }}</h1>
    <div class="destination-details">
      <img :src="`/images/${destination.image}`" :alt="destination.name" />
      <p>{{ destination.description }}</p>
    </div>
  </section>
  <section class="experiences">
    <h2>Top Experiences in {{ destination.name }}</h2>
    <!-- <div class="cards">
      <div v-for="experience in destination.experiences" :key="experience.id" class="card">
        <img :src="`/images/${experience.image}`" :alt="experience.name" />
        <h3>{{ experience.name }}</h3>
        <p>{{ experience.description }}</p>
      </div>
    </div> -->
  </section>
</template>

<script>
//import sourceData from "@/data.json";

export default {
  data() {
    return {
      destination: null,
    };
  },
  //type 5 : dynamic import with named routes
  props: { type: Number, required: true },

  //type 4 : dynamic import with named routes
  // computed: {
  //   destinationId() {
  //     return parseInt(this.$route.params.id);
  //   },

  //type 5 : dynamic import with named routes
  computed: {
    destinationId() {
      return sourceData.destinations.find(
        (destination) => destination.id === this.id
      );
    },

    /*  Reacting to Param Changes type 1 : fetch data from API
      This line of code is commented out because we are now fetching data from an API instead of getting it from the local sourceData.
      Additionally, this line of code would cause an error because the 'destination' property is already defined in the data section, leading to a naming conflict.
    */
    // destination() {
    //   return sourceData.destinations.find(
    //     (destination) => destination.id === this.destinationId
    //   );
  },

  //Reacting to Param Changes type 1 : fetch data from API
  async created() {
    const response = await fetch(
      // `https://travel-dummy-api.netlify.app/${this.$route.params.slug}`
      `https://localhost:44343/GetTravelData?id=${this.$route.params.id}&slug=${this.$route.params.slug}`
    );
    this.destination = (await response.json())[0];
    this.$watch(
      () => this.$route.params,
      async () => {
        const response = await fetch(
          // `https://travel-dummy-api.netlify.app/${this.$route.params.slug}`
          `https://localhost:44343/GetTravelData?id=${this.$route.params.id}&slug=${this.$route.params.slug}`
        );
        this.destination = (await response.json())[0];
      }
    );
  },
};
</script>
