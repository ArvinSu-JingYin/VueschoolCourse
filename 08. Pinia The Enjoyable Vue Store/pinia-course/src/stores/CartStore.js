import { defineStore } from "pinia";

export const useCartStore = defineStore("CartStore", {
    state: () => {
        return {
            items: [],
        };
    },
    getters: {
    //type 1
    // count() {
    //     return this.items.length;
    // },
    // isEmpty() {
    //     return this.count === 0;
    // }

    //type 2
    count: (state) => state.items.length,
    isEmpty: (state) => state.items.length === 0,
    },
    actions: {
        addItems(count,item)
        {
            count = parseInt(count);
            for (let index = 0; index < count; index++) {
                this.items.push({...item});
            }
        }
    }
})
