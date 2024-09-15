<template>
  <section v-if="experiences">
    <h1>{{ experiences.name }}</h1>
    <img :src="`/images/${experiences.image}`" :alt="experiences.name" />
    <p>{{ experiences.description }}</p>
  </section>
</template>

<script>
export default {
  props: {
    id: {
      type: Number,
      required: true,
    },
    experienceSlug: {
      type: String,
      required: true,
    },
    destination: {
      type: Object,
      required: true,
    },
    experiences: {
      type: Object,
      required: true,
    },
  },
  // computed: {
  //   selectedDestination() {
  //     return this.destination.find((destination) => destination.id === this.id);
  //   },
  //   experiences() {
  //     console.log(this.selectedDestination.experiences);
  //     return this.selectedDestination.experiences.find(
  //       (experience) => experience.slug === this.experienceSlug
  //     );
  //   },
  // },
  data() {
    return {
      destination: null,
      experience: null,
    };
  },
  async created() {
    try {
      const response = await fetch(
        `https://localhost:44343/GetTravelData?id=${this.id}`
      );
      this.destination = (await response.json())[0];
      this.experience = this.destination.experiences.find(
        (exp) => exp.slug === this.experienceSlug
      );
    } catch (error) {
      console.error("Error fetching experience data:", error);
    }
  },
};
</script>