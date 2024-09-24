<template class="dark:bg-gray-900 dark:text-white">
  <div class="mx-auto grid max-w-6xl gap-6 p-4 md:grid-cols-2 lg:grid-cols-3">
    <PricingCard
      :name="'Starter'"
      :features="['1GB Storage', '1000 Downloads per Month', 'Basic Support']"
      :price="9.99"
      :description="'Ideal for individuals and small projects'"
    />
    <PricingCard
      :name="'Business'"
      :features="[
        '10GB Storage',
        '10,000 Downloads per Month',
        'Priority Support',
        'Custom Branding',
      ]"
      :price="49.99"
      :description="'Suitable for small to medium-sized businesses'"
    />
    <PricingCard
      :name="'Enterprise'"
      :features="[
        '100GB Storage',
        '100,000 Downloads per Month',
        'Dedicated Support',
        'Custom Branding',
        'Advanced Security Features',
      ]"
      :price="199.99"
      :description="'Designed for large enterprises and organizations'"
    />
  </div>
</template>

<script lang="ts" setup>
import PricingCard from '@/components/PricingCard.vue'
</script>

<style></style>
