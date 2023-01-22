<template>

<label for="honnan">Honnan:</label> <input type="text" name="honnan" id="honnan" value="Budapest" required> 
<label for="hova">Hova:</label> <input type="text" name="hova" id="hova" required> <br>
<label for="datum">Nap:</label><input type="date" name="datum" id="datum" required>
<label for="atszallas">Átszállások száma:</label> <select name="atszallasok" id="atszallasok">
    <option value="0">0</option>
    <option value="1">1</option>
    <option value="2">2</option>
</select>
<br>
<label for="utoasok">Utasok:</label>
<label for="felnott">Felnőtt(16+)</label><input type="number" name="felnott" id="felnott" value="1" min="0"> <br>
<label for="kamasz">Kamasz(12-15)</label><input type="number" name="kamaz" id="kamasz" value="0" min="0"> <br>
<label for="gyerel">Gyerek(2-11)</label><input type="number" name="gyerek" id="gyerek" value="0" min="0"> <br>
<label for="csecsemo">Csecsemő(0-2)</label><input type="number" name="csecsemo" id="csecsemo" value="0" min="0"> <br>
<input type="button" value="Foglalás " onclick="foglalas()">
</template>