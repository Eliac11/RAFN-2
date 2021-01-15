// Created by Crowbar 0.56

$modelname "csgoidf1pm.mdl"

$bodygroup "ct_gign"
{
	studio "csgoidf1pm_ct_gign_reference.smd"
}


$surfaceprop "flesh"

$contents "solid"

$illumposition -0.019 0.305 37.327

$eyeposition 0 0 73

$cdmaterials "models\player\ct_idf\"

$attachment "forward" "ValveBiped.forward" 0 0 0 rotate 0 0 0
$attachment "grenade0" "ValveBiped.Bip01_Spine" 5.99 0.39 7.59 rotate 76.91 71.22 57.14
$attachment "grenade1" "ValveBiped.Bip01_Spine" 6.24 -2.34 6.66 rotate 62.97 100.42 87.46
$attachment "grenade2" "ValveBiped.Bip01_Spine" -0.35 2.21 -8.34 rotate -75.89 92.68 95.17
$attachment "grenade3" "ValveBiped.Bip01_Spine" 1.22 -1.11 -7.34 rotate -78.22 82.38 102.13
$attachment "pistol" "ValveBiped.Bip01_R_Thigh" 0.05 3.84 -6.3 rotate 0.08 -2.59 79.96
$attachment "primary" "ValveBiped.Bip01_Spine2" 10.44 -5.1 -4.88 rotate -11.71 179.79 3.52
$attachment "defusekit" "ValveBiped.Bip01_Pelvis" 0 1.22 -6.66 rotate -73.06 90.93 179.75
$attachment "eholster" "ValveBiped.Bip01_L_Thigh" 5.36 0.02 4.9 rotate 8.31 -91.56 99.67
$attachment "lfoot" "ValveBiped.Bip01_L_Foot" 0 5.2 0 rotate 0 0 0
$attachment "rfoot" "ValveBiped.Bip01_R_Foot" 0 5.2 0 rotate 0 0 0
$attachment "muzzle_flash" "ValveBiped.Bip01_L_Hand" 0 0 0 rotate 0 0 0

$cbox 0 0 0 0 0 0

$bbox -17.835 -29.282 -2.545 9.892 29.319 77.553

$hboxset "cstrike"
$hbox 3 "ValveBiped.Bip01_Pelvis" -8.299 -7.727 -5.429 8.299 2.007 6.583 ""
$hbox 6 "ValveBiped.Bip01_L_Thigh" 4.576 -5.377 -3.432 22.879999 3.775 4.576 ""
$hbox 6 "ValveBiped.Bip01_L_Calf" -0.291 -4.295 -3.432 20.882999 3.151 3.432 ""
$hbox 6 "ValveBiped.Bip01_L_Foot" -2.288 -1.144 -2.579 5.72 4.576 2.007 ""
$hbox 6 "ValveBiped.Bip01_L_Toe0" -2.86 -2.808 -2.86 4.004 1.196 1.716 ""
$hbox 7 "ValveBiped.Bip01_R_Thigh" 4.576 -5.377 -3.432 22.879999 3.775 4.576 ""
$hbox 7 "ValveBiped.Bip01_R_Calf" -0.291 -4.295 -3.432 20.882999 3.151 3.432 ""
$hbox 7 "ValveBiped.Bip01_R_Foot" -2.288 -1.144 -2.007 5.72 4.576 2.579 ""
$hbox 7 "ValveBiped.Bip01_R_Toe0" -2.86 -2.808 -1.716 4.004 1.196 2.86 ""
$hbox 3 "ValveBiped.Bip01_Spine1" -9.152 -1.258 -8.008 4.576 11.326 8.008 ""
$hbox 2 "ValveBiped.Bip01_Spine2" -3.068 -3.432 -9.693 13.572 10.317 9.693 ""
$hbox 1 "ValveBiped.Bip01_Neck1" -0.104 -4.576 -2.86 5.512 2.288 2.86 ""
$hbox 1 "ValveBiped.Bip01_Head1" -0.416 -6.24 -3.64 9.36 4.441 3.016 ""
$hbox 4 "ValveBiped.Bip01_L_UpperArm" -1.144 -2.579 -2.288 14.872 2.579 2.288 ""
$hbox 4 "ValveBiped.Bip01_L_Forearm" -1.716 -2.402 -2.402 13.156 2.402 2.402 ""
$hbox 4 "ValveBiped.Bip01_L_Hand" 0.291 -2.465 -1.716 6.583 1.55 2.86 ""
$hbox 5 "ValveBiped.Bip01_R_UpperArm" -1.144 -2.579 -2.288 14.872 2.579 2.288 ""
$hbox 5 "ValveBiped.Bip01_R_Forearm" -1.716 -2.402 -2.402 13.156 2.402 2.402 ""
$hbox 5 "ValveBiped.Bip01_R_Hand" 0.291 -2.465 -2.86 6.583 1.55 1.716 ""
$skipboneinbbox

$definebone "ValveBiped.Bip01_Pelvis" "" 0 -0.57095 41.266598 0 0 89.999983 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Thigh" "ValveBiped.Bip01_Pelvis" 4.162778 0 0 2.970156 -89.701128 -89.978727 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Calf" "ValveBiped.Bip01_L_Thigh" 19.097538 0 0 0 1.959516 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Foot" "ValveBiped.Bip01_L_Calf" 17.682022 0 0 -2.355087 -61.399931 -1.37487 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Toe0" "ValveBiped.Bip01_L_Foot" 7.361008 0.000001 0.000001 -0.306705 -33.481246 -0.571755 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Thigh" "ValveBiped.Bip01_Pelvis" -4.162778 0 0 2.970156 -90.299008 -90.012243 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Calf" "ValveBiped.Bip01_R_Thigh" 19.097546 0 0 0 1.959516 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Foot" "ValveBiped.Bip01_R_Calf" 17.682016 0 0 2.347294 -61.400164 2.425903 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Toe0" "ValveBiped.Bip01_R_Foot" 7.361015 0 -0.000001 -0.283556 -33.48142 -4.833357 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Spine" "ValveBiped.Bip01_Pelvis" 0 3.579293 -3.190631 4.766608 89.999983 89.999983 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Spine1" "ValveBiped.Bip01_Spine" 4.275544 0 0 0 -1.651035 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Spine2" "ValveBiped.Bip01_Spine1" 3.766718 0 0 0 5.57528 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Spine4" "ValveBiped.Bip01_Spine2" 9.54598 0 0 0 10.680679 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Neck1" "ValveBiped.Bip01_Spine4" 3.537801 -0.000001 0 0 23.268329 179.999856 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_Head1" "ValveBiped.Bip01_Neck1" 3.854136 0.000002 0 -0.000057 23.206685 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Clavicle" "ValveBiped.Bip01_Spine4" 2.203696 1.046375 2.073298 -73.71188 169.030982 91.085395 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_UpperArm" "ValveBiped.Bip01_L_Clavicle" 6.450112 -0.000003 0 2.941795 -33.277966 -82.343662 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Forearm" "ValveBiped.Bip01_L_UpperArm" 12.511029 0.000001 -0.000004 0.000002 -3.459061 -0.000001 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Hand" "ValveBiped.Bip01_L_Forearm" 12.285389 0 -0.000034 -2.217861 2.063908 89.856515 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger2" "ValveBiped.Bip01_L_Hand" 4.153067 0.229723 0.428276 1.812896 -29.791055 5.025241 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger21" "ValveBiped.Bip01_L_Finger2" 1.839947 0.000002 0 0.286766 -20.9981 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger22" "ValveBiped.Bip01_L_Finger21" 1.293815 0 -0.000001 0.160314 -12.398977 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger1" "ValveBiped.Bip01_L_Hand" 4.142277 0.125646 1.391966 -1.889328 -26.576534 20.194873 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger11" "ValveBiped.Bip01_L_Finger1" 1.839789 0.000003 0.000001 0.29261 -20.798196 0.000061 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger12" "ValveBiped.Bip01_L_Finger11" 1.176632 0.000002 -0.000002 0.186556 -13.99868 0.000061 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger0" "ValveBiped.Bip01_L_Hand" 0.897548 -0.321295 1.404668 -38.376716 -41.260582 -71.677536 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_L_Finger01" "ValveBiped.Bip01_L_Finger0" 1.915067 -0.000002 0.000004 -0.123704 13.09954 -0.000002 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Clavicle" "ValveBiped.Bip01_Spine4" 2.203695 1.046376 -2.073298 73.71188 169.030982 -95.200892 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_UpperArm" "ValveBiped.Bip01_R_Clavicle" 6.450111 -0.000001 0 -0.682163 -33.42711 87.135647 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Forearm" "ValveBiped.Bip01_R_UpperArm" 12.511032 -0.000002 -0.000004 0 -3.459061 -0.000001 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Hand" "ValveBiped.Bip01_R_Forearm" 12.285415 0 0.000004 2.217403 2.063908 -89.381017 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger2" "ValveBiped.Bip01_R_Hand" 4.153036 0.226164 -0.430167 -2.049068 -29.776736 -5.025813 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger21" "ValveBiped.Bip01_R_Finger2" 1.83995 -0.000002 0 -0.43453 -20.995756 0 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger22" "ValveBiped.Bip01_R_Finger21" 1.293818 0 -0.000001 -0.24299 -12.397718 0.000001 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger1" "ValveBiped.Bip01_R_Hand" 4.142242 0.114089 -1.39296 1.67659 -26.589365 -20.195959 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger11" "ValveBiped.Bip01_R_Finger1" 1.839788 -0.000001 0 -0.443297 -20.795734 0.000003 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger12" "ValveBiped.Bip01_R_Finger11" 1.17664 -0.000005 -0.000001 -0.28241 -13.997131 0.000002 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger0" "ValveBiped.Bip01_R_Hand" 0.897524 -0.332967 -1.401953 38.062158 -41.54105 71.507082 0 0 0 0 0 0
$definebone "ValveBiped.Bip01_R_Finger01" "ValveBiped.Bip01_R_Finger0" 1.91507 -0.000001 0.000001 0.18787 13.098789 -0.000003 0 0 0 0 0 0
$definebone "ValveBiped.forward" "ValveBiped.Bip01_Head1" 2.000005 -3.000001 0 0 -75.999987 -89.999983 0 0 0 0 0 0


$ikchain "rhand" "ValveBiped.Bip01_R_Hand" knee 0.707 0.707 0
$ikchain "lhand" "ValveBiped.Bip01_L_Hand" knee 0.707 0.707 0
$ikchain "rfoot" "ValveBiped.Bip01_R_Foot" knee 0.707 -0.707 0
$ikchain "lfoot" "ValveBiped.Bip01_L_Foot" knee 0.707 -0.707 0

$sequence "ragdoll" {
	"csgoidf1pm_anims\ragdoll.smd"
	activity "ACT_DIERAGDOLL" 1
	fadein 0.2
	fadeout 0.2
	fps 30
	ikrule "rhand" release
	ikrule "lhand" release
	ikrule "rfoot" release
	ikrule "lfoot" release
}

$includemodel "m_anm.mdl"

$collisionjoints "csgoidf1pm_physics.smd"
{
	$mass 100
	$inertia 10
	$damping 0.05
	$rotdamping 5
	$rootbone "valvebiped.bip01_pelvis"

	$jointrotdamping "ValveBiped.Bip01_Pelvis" 3

	$jointmassbias "ValveBiped.Bip01_Spine1" 8
	$jointconstrain "ValveBiped.Bip01_Spine1" x limit -10 10 0
	$jointconstrain "ValveBiped.Bip01_Spine1" y limit -16 16 0
	$jointconstrain "ValveBiped.Bip01_Spine1" z limit -20 30 0

	$jointmassbias "ValveBiped.Bip01_Spine2" 9
	$jointconstrain "ValveBiped.Bip01_Spine2" x limit -10 10 0
	$jointconstrain "ValveBiped.Bip01_Spine2" y limit -10 10 0
	$jointconstrain "ValveBiped.Bip01_Spine2" z limit -20 20 0

	$jointmassbias "ValveBiped.Bip01_R_Clavicle" 4
	$jointrotdamping "ValveBiped.Bip01_R_Clavicle" 6
	$jointconstrain "ValveBiped.Bip01_R_Clavicle" x limit -15 15 0
	$jointconstrain "ValveBiped.Bip01_R_Clavicle" y limit -10 10 0
	$jointconstrain "ValveBiped.Bip01_R_Clavicle" z limit 0 45 0

	$jointmassbias "ValveBiped.Bip01_L_Clavicle" 4
	$jointrotdamping "ValveBiped.Bip01_L_Clavicle" 6
	$jointconstrain "ValveBiped.Bip01_L_Clavicle" x limit -15 15 0
	$jointconstrain "ValveBiped.Bip01_L_Clavicle" y limit -10 10 0
	$jointconstrain "ValveBiped.Bip01_L_Clavicle" z limit 0 45 0

	$jointmassbias "ValveBiped.Bip01_L_UpperArm" 5
	$jointrotdamping "ValveBiped.Bip01_L_UpperArm" 2
	$jointconstrain "ValveBiped.Bip01_L_UpperArm" x limit -15 20 0
	$jointconstrain "ValveBiped.Bip01_L_UpperArm" y limit -40 32 0
	$jointconstrain "ValveBiped.Bip01_L_UpperArm" z limit -80 25 0

	$jointmassbias "ValveBiped.Bip01_L_Forearm" 4
	$jointrotdamping "ValveBiped.Bip01_L_Forearm" 4
	$jointconstrain "ValveBiped.Bip01_L_Forearm" x limit -40 15 0
	$jointconstrain "ValveBiped.Bip01_L_Forearm" y limit 0 0 0
	$jointconstrain "ValveBiped.Bip01_L_Forearm" z limit -120 10 0

	$jointrotdamping "ValveBiped.Bip01_L_Hand" 1
	$jointconstrain "ValveBiped.Bip01_L_Hand" x limit -25 25 0
	$jointconstrain "ValveBiped.Bip01_L_Hand" y limit -35 35 0
	$jointconstrain "ValveBiped.Bip01_L_Hand" z limit -50 50 0

	$jointmassbias "ValveBiped.Bip01_R_UpperArm" 5
	$jointrotdamping "ValveBiped.Bip01_R_UpperArm" 2
	$jointconstrain "ValveBiped.Bip01_R_UpperArm" x limit -15 20 0
	$jointconstrain "ValveBiped.Bip01_R_UpperArm" y limit -40 32 0
	$jointconstrain "ValveBiped.Bip01_R_UpperArm" z limit -80 25 0

	$jointmassbias "ValveBiped.Bip01_R_Forearm" 4
	$jointrotdamping "ValveBiped.Bip01_R_Forearm" 4
	$jointconstrain "ValveBiped.Bip01_R_Forearm" x limit -40 15 0
	$jointconstrain "ValveBiped.Bip01_R_Forearm" y limit 0 0 0
	$jointconstrain "ValveBiped.Bip01_R_Forearm" z limit -120 10 0

	$jointrotdamping "ValveBiped.Bip01_R_Hand" 1
	$jointconstrain "ValveBiped.Bip01_R_Hand" x limit -25 25 0
	$jointconstrain "ValveBiped.Bip01_R_Hand" y limit -35 35 0
	$jointconstrain "ValveBiped.Bip01_R_Hand" z limit -50 50 0

	$jointmassbias "ValveBiped.Bip01_R_Thigh" 7
	$jointrotdamping "ValveBiped.Bip01_R_Thigh" 7
	$jointconstrain "ValveBiped.Bip01_R_Thigh" x limit -25 25 0
	$jointconstrain "ValveBiped.Bip01_R_Thigh" y limit -10 15 0
	$jointconstrain "ValveBiped.Bip01_R_Thigh" z limit -55 25 0

	$jointmassbias "ValveBiped.Bip01_R_Calf" 4
	$jointconstrain "ValveBiped.Bip01_R_Calf" x limit -10 25 0
	$jointconstrain "ValveBiped.Bip01_R_Calf" y limit -5 5 0
	$jointconstrain "ValveBiped.Bip01_R_Calf" z limit -10 115 0

	$jointmassbias "ValveBiped.Bip01_L_Thigh" 7
	$jointrotdamping "ValveBiped.Bip01_L_Thigh" 7
	$jointconstrain "ValveBiped.Bip01_L_Thigh" x limit -25 25 0
	$jointconstrain "ValveBiped.Bip01_L_Thigh" y limit -10 15 0
	$jointconstrain "ValveBiped.Bip01_L_Thigh" z limit -55 25 0

	$jointmassbias "ValveBiped.Bip01_L_Calf" 4
	$jointconstrain "ValveBiped.Bip01_L_Calf" x limit -10 25 0
	$jointconstrain "ValveBiped.Bip01_L_Calf" y limit -5 5 0
	$jointconstrain "ValveBiped.Bip01_L_Calf" z limit -10 115 0

	$jointmassbias "ValveBiped.Bip01_Head1" 4
	$jointrotdamping "ValveBiped.Bip01_Head1" 3
	$jointconstrain "ValveBiped.Bip01_Head1" x limit -50 50 0
	$jointconstrain "ValveBiped.Bip01_Head1" y limit -20 20 0
	$jointconstrain "ValveBiped.Bip01_Head1" z limit -26 30 0
}
