<template>
    <form id="foglalas">
        <div class="row">
            <div class="col">
                <label for="honnan">Honnan </label> <input class="form-control" type="text" name="honnan" id="honnan"
                    value="Budapest" required>
            </div>
            <div class="col">
                <label for="hova">Hova</label> <input type="text" name="hova" class="form-control" id="hova" required
                    placeholder="Anyádhoz"> <br>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label for="datum">Indulás napja</label><br><input type="date" class="form-control" name="datum"
                    id="datum" required>
            </div>
            <div class="col d-flex align-self-center justify-content-center" >
                <div class="form-check form-switch d-flex  justify-content-center ">
                    <input class="form-check-input " onclick="odavissza()" type="checkbox" id="odavissza">
                    <label class="form-check-label"  id="lavel" for="flexSwitchCheckDefault">Oda-Vissza</label>
                </div>
            </div>
            <div class="col">
                <label for="datum">Érkezés napja</label><br><input type="date" class="form-control" name="datum"
                    id="datumvissza" disabled>
            </div>
        </div>

        <br>
        <div class="center">
            <label for="utoasok">
                <h5>Utasok</h5>
            </label>
        </div>
        <div class="row">
            <div class="col">
                <label for="felnott">Felnőtt(16+)</label><input type="number" class="form-control" name="felnott"
                    id="felnott" value="1" min="0">
            </div>
            <div class="col">
                <label for="kamasz">Kamasz(12-15)</label><input type="number" class="form-control" name="kamaz"
                    id="kamasz" value="0" min="0">
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label for="gyerel">Gyerek(2-11)</label><input type="number" class="form-control" name="gyerek"
                    id="gyerek" value="0" min="0">
            </div>
            <div class="col">
                <label for="csecsemo">Csecsemő(0-2)</label><input type="number" class="form-control" name="csecsemo"
                    id="csecsemo" value="0" min="0">
            </div>
        </div>
        <br>
        <input type="button" value="Foglalás" class="form-control" onclick="foglalas()">
    </form>
</template>