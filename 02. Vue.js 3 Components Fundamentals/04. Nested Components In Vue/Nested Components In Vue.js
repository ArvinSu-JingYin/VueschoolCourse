Vue.createApp({
})
.component('plan',{
    template: '#plan-template',
    props: {
        name: {type: String, required: true}
    },
})
.component('plan-picker',{
    template: '#plan-picker-template',
    data() {
        return {
            plansPickers:['The Single1','The Curious2','The Addict3']
        }
    },
})
.mount('#app');
