<template>
  <section v-if="destination" class="destination">
    <h1>{{ destination.name }}</h1>
    <div class="destination-details">
      <img :src="`/images/${destination.image}`" :alt="destination.name" />
      <p>{{ destination.description }}</p>
    </div>
  </section>
</template>

<script>
import sourceData from "@/data.json";

export default {
  data() {
    return {
      destination: null,
    };
  },
  computed: {
    destinationId() {
      return parseInt(this.$route.params.id);
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
      `https://travel-dummy-api.netlify.app/${this.$route.params.slug}`
    );
    this.destination = await response.json();
    this.$watch(
      () => this.$route.params,
      async () => {
        const response = await fetch(
          `https://travel-dummy-api.netlify.app/${this.$route.params.slug}`
        );
        this.destination = await response.json();
      }
    );
  },
};
</script>
