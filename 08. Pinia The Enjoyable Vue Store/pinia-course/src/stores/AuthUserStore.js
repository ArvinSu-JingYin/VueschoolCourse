import { defineStore } from "pinia"

export const useAuthUserStore = defineStore('authUser', {

state: () => ({
    username: null,
    }),
})
