<template>
  <div id="app">
    <NavBar/>
    <Header/>
    <Content/>
  </div>
</template>

<script>
import NavBar from './components/layouts/NavBar.vue'
import Header from './components/layouts/Header.vue'
import Content from './components/layouts/Content.vue'

export default {
  name: 'App',
  components: {
    NavBar,
    Header,
    Content
  }
}
</script>

<style>
@import "./components/styles/main.css";
@import "./components/styles/input.css";
@import "./components/styles/table.css";
@import "./components/styles/dropdown.css";
</style>
