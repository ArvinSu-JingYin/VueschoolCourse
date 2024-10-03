<template>
  <div class=" relative">
    <div class=" rounded-2xl overflow-hidden bg-[#323239] border-white border-2 grid grid-cols-9 relative z-10">
      <CartCheckoutColumnLeft />
      <CartCheckoutColumnRight />
    </div>
    <CartCheckoutShadow />
  </div>
</template>

<script lang="ts" setup>
import CartCheckoutColumnLeft from '~/components/CartCheckoutColumnLeft.vue';
import CartCheckoutColumnRight from '~/components/CartCheckoutColumnRight.vue';
import CartCheckoutShadow from '~/components/CartCheckoutShadow.vue';
</script>

<style>

</style>