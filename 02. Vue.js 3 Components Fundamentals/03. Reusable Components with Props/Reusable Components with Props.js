Vue.createApp({
    data() {
        return {
            plans:['The Single','The Curious','The Addict']
        }
    },
})
.component('plan',{
    template: '#plan-template',
})
.component('plan0',{
    template: '#plan-template-0',
    props: ['name0']
})
.component('plan-1',{
    template: '#plan-template-1',
    props: {
        name1: {type: String, default: 'The Single', required:true},
        price: Number
    }
})
.mount('#app');
