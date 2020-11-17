<template>
  <div class="user-header">
    <img src="../assets/images/blank-profile-picture.png" alt="Avatar">
    <p>Username</p>
    <p>Shows added: 64</p>
  </div>
</template>
    
<script>
export default {
  name: "UserHeader"  
}
//get the profile and background images passed from database?

</script>

<style scoped>
img {
  border-radius: 50%;
}
.user-header{
    background: dimgrey;
}
</style>