import { defineNuxtConfig } from "nuxt/config";

// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  compatibilityDate: "2024-04-03",

  ssr: true,
  devtools: { enabled: true },

  modules: ["@pinia/nuxt"],
  imports: {
    dirs: ["stores"],
  },
  routeRules: {
    "/spa": { ssr: false } as any,
    "/static": { static: true },
    "/swr": { swr: true },
  },
});
