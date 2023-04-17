-- Le mode de jeu est REVERSE : Vous n'avez pas accès à l'énoncé. Vous devez trouver quoi faire en observant les jeux de tests suivants :

-- Test 1

-- Entrée
-- a

-- Sortie attendue
-- 97

-- Test 2

-- Entrée
-- A

-- Sortie attendue
-- 0

-- DUREE
-- 00:06:59

s = io.read()
result = 0

for i = 1, #s do
    if string.byte(s:sub(i,i)) > 96 then
        result = result + string.byte(s:sub(i,i))
    end
end

print(result)