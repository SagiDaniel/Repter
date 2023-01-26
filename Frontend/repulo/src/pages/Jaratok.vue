<template>
    <form id="foglalas">
        <div class="row">
            <div class="col">
                <label for="honnan">Honnan </label> <input class="form-control" type="text" name="honnan" id="honnan"
                    value="Budapest" required>
            </div>
            <div class="col">
                <label for="hova">Hova</label> <input type="text" name="hova" class="form-control" id="hova" required
                    placeholder="Haza"> <br>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label for="datum">Indulás napja</label><br><input type="date" class="form-control" name="datum"
                    id="datum" required>
            </div>
            <div class="col d-flex align-self-center justify-content-center" >
                <div class="form-check form-switch d-flex  justify-content-center ">
                    <input class="form-check-input "  v-model="odavissza" type="checkbox" id="odavissza">
                    <label class="form-check-label"  id="lavel" for="flexSwitchCheckDefault">Oda-Vissza</label>
                </div>
            </div>
            <div class="col">
                <label for="datum">Hazaút napja</label><br><input type="date" class="form-control" name="datum"
                    id="datumvissza" :disabled="odavissza">
            </div>
        </div>
        <div id="hazaut"></div>
        <br>
        <div class="center">
            <label for="utoasok">
                <h5>Utasok</h5>
            </label>
        </div>
        <div class="row">
            <div class="col">
                <label for="felnott">Felnőtt(16+)</label><input type="number" v-modal="felnott" class="form-control" name="felnott"
                    id="felnott" value="1" min="0">
            </div>
            <div class="col">
                <label for="kamasz">Kamasz(12-15)</label><input type="number" v-modal="kamasz" class="form-control" name="kamaz"
                    id="kamasz" value="0" min="0">
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label for="gyerel">Gyerek(2-11)</label><input type="number" v-modal="gyerek" class="form-control" name="gyerek"
                    id="gyerek" value="0" min="0">
            </div>
            <div class="col">
                <label for="csecsemo">Csecsemő(0-2)</label><input type="number" v-modal="csecsemo" class="form-control" name="csecsemo"
                    id="csecsemo" value="0" min="0">
            </div>
        </div>
        <br>
        <input type="button" value="Foglalás" class="form-control" onclick="foglalas()">
    </form>
</template>
<script>
export default {

 foglalas() {
  //áfa 27%
  //kerozin távolság*0,10+tavolsag
  //celallomas populacio 0m-2m=>5% 2m-10m=>7,5%   10m+=10% 
  //csoportos kedvezmeny 10fo 10% vegosszegbol
  //16ev alatt vegosszeg 80%

  const uticel = 0;
  //uticel = document.getElementById().value;
  const uticellakossag = 0;
  //uticellakossag=document.getElementById().value;
  const uticelszorzo = 0;
  const csoport = this.felnott + this.kamasz + this.gyerek + this.csecsemo;
  if (uticellakossag > 10000000) {
    uticelszorzo = 0.10;
  }
  else if (uticellakossag > 2000000) {
    uticelszorzo = 0.05;
  }
  else {
    uticelszorzo = 0.02;
  }
  const vegosszeg = 0;
  const kerozinar = 0;
  const arseged = 0;
  kerozinar = (uticel * 0, 27 + uticel) * uticelszorzo;//ÁFA+lakossagszorzo

  if (felnott != 0) {
    vegosszeg += kerozinar * this.felnott;
  }
  if (kamasz != 0) {
    arseged = kerozinar * this.kamasz;
    vegosszeg += arseged * 0.80;
  }
  if (gyerek != 0) {
    arseged = kerozinar * this.gyerek;
    vegosszeg += arseged * 0.80;
  }
  if (csecsemo != 0) {
    arseged = kerozinar * this.csecsemo;
    vegosszeg += arseged * 0.80;
  }
  if (csoport > 9) {
    vegosszeg = vegosszeg * 0.80;
  }
  if (hazais = 1) {
    vegosszeg = vegosszeg * 2;
  }
  alert(vegosszeg, " Ft ennyi lesz a foglálás");
}
}
</script>