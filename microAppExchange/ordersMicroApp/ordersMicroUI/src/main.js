import { createApp } from 'vue'
import { createPinia } from 'pinia'
import App from './App.vue'
import 'mdb-vue-ui-kit/css/mdb.min.css';
import 'http://localhost:5173/src/assets/main.css'

const app = createApp(App)

app.use(createPinia())

app.mount('#app')
