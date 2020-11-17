<template>
  <div class="show-div">
    <img :src="imagePath" :alt="showName" />
    <p class="text-border-width">{{ showName }}</p>
  </div>
</template>

<script>
export default {
  name: "Show",
  props: {
    imagePath: String,
    showName: String,
  },
};
</script>

<style scoped>
img {
  width: 250px;
  height: 380px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
}

.text-border-width {
  text-shadow: -1px 0 whitesmoke, 0 1px whitesmoke, 1px 0 whitesmoke,
    0 -1px whitesmoke;
  font-size: 20px;
  width: 250px;
}

.show-div {
  padding: 25px;
}
</style>
