<template>
  <form action="">
    <div class="d-flex align-self-center justify-content-center">
<audio id="my-audio" controls autoplay >
  <source src="../assets/css/music.mp3" type="audio/mpeg" >
  Your browser does not support the audio element.
</audio></div></form>
 <form action="" method="post" class="fizetes">
  <label for="">Város</label><br>
  <input type="text" name="varos" id="varos" placeholder="Szingapúr" v-model="varos" class="form-control" required>
  <br>
  <label for="">Lakosság</label><br>
  <input type="number" name="letszam" id="letszam" class="form-control" v-model="letszam" placeholder="50000" required><br>
  <input type="button" class="form-control"  value="Új adat" @click="varosuj()">
 </form>
</template>
<script>
export default {methods:{
varosuj() {
if (this.varos != "" && this.letszam != "") {
  fetch("https://localhost:7161/city", {
    method: 'POST',
    headers: {
      "Access-Control-Allow-Origin": "*",
      "Accept": "application/json",
      "Content-Type": "application/json"
    },
    body: `{
      "nev": "${this.varos}",
      "nepesseg": ${this.letszam}
      }`,
    }).then (respone => respone.json()).then(data=>console.log(data));
    alert("Siker");
}

}
},data(){
return {varos:"",letszam:0};
}};
</script>