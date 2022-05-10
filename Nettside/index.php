    <?php
        include_once 'header.php';
    ?>

<?php
    if (isset($_SESSION["Username"])) {
        echo "<p id='hello'>Hello there " . $_SESSION["Username"] . ".</p>";
    }
?>

        <h3>Welcome!</h3>
        <p>To the main page of CNACK, a 2D-platformer game project. The game is still in early development, and is thus unfinished. There will probably be many bugs and issues because of this, so keep this in mind if you decide to install the game.</p>

        <h3>Upcoming improvements:</h3>
        <p><span>&#9632;</span> A system for saving player users and stats</p>
        <p><span>&#9632;</span> Multiplayer</p>
        <p><span>&#9632;</span> Finishing the game</p>
        <br>
        <p>For a list of previous updates, visit the github page (link in downloads).</p>

        <h3>How to download</h3>
        <p>You need a user to download the game. Create a user, log in, and you'll be able to enter the download page. Click the download link, or download the files from github.</p>

        <h3>How to play</h3>

        <h4>Controlls</h4>
        <p>Press <span class="highlight">&#8592;</span> and <span class="highlight">&#8594;</span> arrow keys to move left or right.</p>
        <p>Press <span class="highlight">&#8595;</span> arrow key to go down from semisolid platforms.</p>
        <p>Press <b class="highlight">Z</b> button to jump.</p>
        <p>Press <b class="highlight">X</b> button to activate abilities.</p>
        <p>Press <b class="highlight">A</b> To teleport back to previous checkpoints.</p>

        <h4>Gameplay</h4>
        <p>In singleplayer, you have to play through <b class="highlight">levels</b>. These levels are the <b class="factoryLV">Factory</b>,the <b class="dungeonLV">Dungeon</b>, and the <b class="satelliteLV">Satellite</b> (in that order).</p>
        <img src="media/img/lvl1.png" class="img" alt="Factory">
        <img src="media/img/lvl2.png" class="img" alt="Dungeon">
        <img src="media/img/lvl3.png" class="img" alt="Satellite">   

        <p>Each level has unique obstacles that you have to overcome and to complete a level, you must reach the <b class="highlight">goal</b>.</p>
        <img src="media/img/goal.png" class="imgIconvar2" alt="Goal">

        <p>When a level is completed, the next level will <b class="highlight">unlock</b>, and you'll be able to play it.</p>
        
        <h4>Lives, Checkpoints & Coins</h4>
        <p>You can have a total of <b class="danger">3 lives</b>. Every time you collide with an <b class="danger">enemy</b>, you will lose a life. If you get to <b class="danger">0 lives</b>, you will get game over, and must restart the level.</p>
        <img src="media/img/health.png" class="imgIconvar1" alt="Health Icon">

        <p>Whenever you reach a <b class="highlight">checkpoint</b>, it will activate by turning blue. If you lose a life, you will be teleported back to the previously activated checkpoint.</p>
        <img src="media/img/checkPoint.png" class="imgIconvar2" alt="Checkpoint">
        <img src="media/img/checkPointActive.png" class="imgIconvar2" alt="Activated Checkpoint">

        <p><b class="golden">Coins</b> can be collected in each level. If you gain a <b class="golden">100 coins</b>, you will gain <b class="danger">1 extra life</b>. In multiplayer mode, you can win by aquiring <b class="golden">more coins</b> than the other players.</p>
        <img src="media/img/coin.png" class="imgIconvar1" alt="Coin">

        <h4>Abilities</h4>
        <p>There are a total of <b class="highlight">6 abilities</b>. These are the <b class="highlight">Magnet</b>, <b class="highlight">Shield</b>, <b class="highlight">Blindness</b>, <b class="highlight">Push Spell</b>, <b class="highlight">Gravity Swap</b> and <b class="highlight">Heal</b>. These abilities can be found in <b class="highlight">Ability Boxes</b> scattered around each level.</p>
        <img src="media/img/abilityBox.png" class="imgIconvar1" alt="Ability Box">

        <p>The <b class="highlight">Magnet</b> creates a field around you for <b class="highlight">10 seconds</b>, and any coins close to that field will be drawn towards you.</p>
        <img src="media/img/magnet.png" class="imgIconvar1" alt="Magnet Icon">

        <p>The <b class="highlight">Shield</b> creates a protective bubble around you, giving you an extra life. Shield also protects you from projectiles. The shield will be destroyed if you take damage from non-projectile attacks.</p>
        <img src="media/img/shield.png" class="imgIconvar1" alt="Shield Icon">

        <p>The <b class="highlight">Blindness</b> allows you to move around unnoticed. Turrets, mages, orbs and defenders won't attack you for <b class="highlight">10 seconds</b>. In multiplayer mode, you will temporarily blind other players.</p>
        <img src="media/img/blindness.png" class="imgIconvar1" alt="Blindness Icon">

        <p>The <b class="highlight">Push Spell</b> creates a field around you for a limited time, pushing anything away from you. This keeps you safe, and can be used to sabotage other players in multiplayer mode.</p>
        <img src="media/img/pushSpell.png" class="imgIconvar1" alt="pushSpell Icon">

        <p>The <b class="highlight">Gravity Swap</b> swaps the gravity around you (won't affect others) for <b class="highlight">10 seconds</b>. You can thus walk on the roof and freely change gravity whenever you like.</p>
        <img src="media/img/gravSwap.png" class="imgIconvar1" alt="Gravity Swap Icon">

        <p>The <b class="highlight">Heal</b> will restore you back to full health.</p>
        <img src="media/img/heal.png" class="imgIconvar1" alt="Heal Icon">


        <h4>Enemies</h4>
        <p>Watch out for <b class="danger">red obstacles</b>! These obstacles are <b class="danger">enemies</b> and will hurt you if you touch them.</p>
        <p>There are many types of enemies, and they all have different behaviours.</p>

        <p><b class="danger">Sentinels</b> walk back and forth, and will eliminate anything that comes in their path.</p>
        <img src="media/img/sentinel.gif" class="imgIcon" alt="Sentinel">

        <p><b class="danger">Circs</b> are small orbs that float around. They move up and down in repeat.These enemies cannot be hurt. Some Circs have a protective field around them. You should stay away from those.</p>
        <img src="media/img/circ.gif" class="imgIconvar1" alt="Circ">
        <img src="media/img/protectedCirc.gif" class="imgIconvar2" alt="Protected Circ">

        <p><b class="danger">Spikes</b> are static enemies that cannot hurt you, unless you land on top of them.</p>
        <img src="media/img/spike.png" class="imgIconvar1" alt="Spike">

        <p><b class="danger">Turrets</b> are also static enemies, but unlike spikes, they shoot bullets towards you.</p>
        <img src="media/img/turret.gif" class="imgIconvar1" alt="Turret">

        <p><b class="danger">Orbs</b> are floating enemies that constantly follows you everywhere you go. Shake them off by hiding behind walls and platforms.</p>
        <img src="media/img/orb.png" class="imgIconvar1" alt="Orb">

        <p><b class="danger">Fishes</b> are only found underwater, swimming back and forth. They are often together in large numbers, so watch out when swimming!</p>
        <img src="media/img/fish.png" class="imgIconvar3" alt="Fish">

        <p><b class="danger">Mages</b> are like moving turrets. They shoot at you while moving back and forth. However, they have a small pause after each shot. Best using that to your advantage.</p>
        <img src="media/img/mage.gif" class="imgIconvar2" alt="Mage">

        <p><b class="danger">Defenders</b> are like sentinels, just way more aggressive. They walk back and forth, but when you appear before them, they quickly charge forward. Thus, it's best staying behind them at all costs.</p>
        <img src="media/img/defender.gif" class="imgIcon" alt="Defender">
        <img src="media/img/chargingDefender.png" class="imgIcon" alt="Charging Defender">

        <p>At the end of levels you'll encounter <b class="danger">bosses</b>. These enemies are more difficult to defend against than <b class="danger">regular enemies</b>, and you'll have to memorize their behaviour in order to win. If you survive their attacks till time reaches <b class="danger">0</b>, you win and the level is completed.</p>

        <h4>And that's all! Good luck.</h4>

    <?php
        include_once 'footer.php';
    ?>