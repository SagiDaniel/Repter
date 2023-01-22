<template>
    <form id="foglalas">
<label for="honnan">Honnan </label> <input class="form-control" type="text" name="honnan" id="honnan" value="Budapest" required>
<label for="hova" >Hova</label> <input type="text" name="hova" class="form-control" id="hova" required placeholder="Anyádhoz"> <br>
<label for="datum">Indulás napja</label><br><input type="date" class="form-control" name="datum" id="datum" required><br>
<div class="form-check form-switch">
      <input class="form-check-input" type="checkbox" id="labelsss">
      <label class="form-check-label" onclick="odavissza()" id="odavissza" for="flexSwitchCheckDefault">Oda-Vissza</label>
    </div>
    
<label for="datum">Érkezés napja</label><br><input type="date" class="form-control" name="datum" id="datumvissza" disabled> <br>
<label for="atszallas">Átszállások száma</label> <select name="atszallasok" class="form-control" id="atszallasok">
    <option value="0">0</option>
    <option value="1">1</option>
    <option value="2">2</option>
</select>
<br>
<div class="center">
<label for="utoasok" >Utasok</label> </div>
<label for="felnott">Felnőtt(16+)</label><input type="number" class="form-control" name="felnott" id="felnott" value="1" min="0"> <br>
<label for="kamasz">Kamasz(12-15)</label><input type="number" class="form-control" name="kamaz" id="kamasz" value="0" min="0"> <br>
<label for="gyerel">Gyerek(2-11)</label><input type="number" class="form-control" name="gyerek" id="gyerek" value="0" min="0"> <br>
<label for="csecsemo">Csecsemő(0-2)</label><input type="number" class="form-control" name="csecsemo" id="csecsemo" value="0" min="0"> <br>
<input type="button" value="Foglalás" class="form-control" onclick="foglalas()">
</form>
</template>