import { useState } from "react"

const[Var1, setVar1] = useState(0)

function count(){

    function handlecount(){
        setVar1(Var1+1)
    }
    return (
        <>
        
        <h1>{Var1}</h1>
        <button onClick={handlecount}>increment</button>
        </>
    )
}
export default count