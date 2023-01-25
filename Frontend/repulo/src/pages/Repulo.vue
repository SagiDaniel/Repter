<template>
  <form action="">
    <div class="d-flex align-self-center justify-content-center">
<audio id="my-audio" controls autoplay >
  <source src="../assets/css/music.mp3" type="audio/mpeg" >
  Your browser does not support the audio element.
</audio></div></form>
 <form action="" method="post" class="fizetes">
  <label for="">Város</label><br>
  <input type="text" name="varos" id="varos" placeholder="Szingapúr" class="form-control" required>
  <br>
  <label for="">Lakosság</label><br>
  <input type="number" name="letszam"  id="letszam" class="form-control" placeholder="50000" required><br>
  <input type="button" class="form-control"  value="Új adat" onclick="varosuj()" >
 </form>
</template>
